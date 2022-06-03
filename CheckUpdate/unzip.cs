using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;

namespace CheckUpdate
{
    public abstract class Unzip
    {
        private static bool justHadByteUpdate = false;

        public static void ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Extracting_EntryBytesWritten)
            {

                Console.Write("   {0}/{1} ({2:N0}%)", e.BytesTransferred, e.TotalBytesToTransfer,
                          e.BytesTransferred / (0.01 * e.TotalBytesToTransfer));
                justHadByteUpdate = true;
            }
            else if (e.EventType == ZipProgressEventType.Extracting_BeforeExtractEntry)
            {
                if (justHadByteUpdate)
                    Console.WriteLine();
                Console.WriteLine("Extracting: {0}", e.CurrentEntry.FileName);
                justHadByteUpdate = false;
            }
        }

        public static bool zipExtractFinished = false;
        public static async void ExtractZip(string zipToExtract, string directory)
        {
            await Task.Run(() =>
            {
                using (var zip = ZipFile.Read(zipToExtract))
                {
                    //zip.ExtractProgress += ExtractProgress;
                    zip.ExtractProgress += zip_ExtractProgress;
                    zip.ExtractAll(directory, ExtractExistingFileAction.OverwriteSilently);
                    foreach (var e in zip)
                    {
                        Var.info = zipExtractFinished;
                        //e.Extract(directory, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
            }).ContinueWith(t =>
            {
                zipExtractFinished = true;
                Var.info = zipExtractFinished;
                File.Delete(zipToExtract);
            });
        }

        static void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Extracting_EntryBytesWritten)
            {
                Var.infoProgress = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                Var.infoFileName = e.CurrentEntry.FileName;
            }

            else if (e.EventType == ZipProgressEventType.Extracting_AfterExtractAll)
                Var.infoProgress = 100;
        }

        /*public static void zip_ExtractProgress(object sender, ExtractProgressEventArgs e)
        {
            //ver.progressInstall.Value = 0;
            if (e.TotalBytesToTransfer > 0)
            {
                // progressInstall.Value = Convert.ToInt32(100 * e.BytesTransferred / e.TotalBytesToTransfer);
            }
        }*/
    }
}
