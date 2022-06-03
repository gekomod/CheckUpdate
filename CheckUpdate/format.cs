using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace CheckUpdate
{
    internal class Format
    {

        public static bool FormatUSB(string driveLetter, string fileSystem = "FAT32", bool quickFormat = true,
                                   int clusterSize = 4096, string label = "USB_0000", bool enableCompression = false)
        {
            //add logic to format Usb drive
            //verify conditions for the letter format: driveLetter[0] must be letter. driveLetter[1] must be ":" and all the characters mustn't be more than 2
            if (driveLetter.Length != 3 || driveLetter[1] != ':' || !char.IsLetter(driveLetter[0]))
                return false;

            string driveLetterNew = driveLetter[0] + ":";

            //query and format given drive 
            //best option is to use ManagementObjectSearcher

            var files = Directory.GetFiles(driveLetter);
            var directories = Directory.GetDirectories(driveLetter);

            foreach (var item in files)
            {
                try
                {
                    File.Delete(item);
                }
                catch (UnauthorizedAccessException) { }
                catch (IOException) { }
            }

            foreach (var item in directories)
            {
                try
                {
                    Directory.Delete(item);
                }
                catch (UnauthorizedAccessException) { }
                catch (IOException) { }
            }

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"select * from Win32_Volume WHERE DriveLetter = '" + driveLetterNew + "'");
            foreach (ManagementObject vi in searcher.Get())
            {
                try
                {
                    var completed = false;
                    var watcher = new ManagementOperationObserver();

                    watcher.Completed += (sender, args) =>
                    {
                        Console.WriteLine("USB format completed " + args.Status);
                        completed = true;
                    };
                    watcher.Progress += (sender, args) =>
                    {
                        Console.WriteLine("USB format in progress " + args.Current);
                    };

                    vi.InvokeMethod(watcher, "Format", new object[] { fileSystem, quickFormat, clusterSize, label, enableCompression });

                    while (!completed) { System.Threading.Thread.Sleep(1000); }


                }
                catch
                {

                }
            }
            return true;
        }

    }
}
