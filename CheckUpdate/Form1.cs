using Ionic.Zip;
using NUnit.Framework.Constraints;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Sdcard;

namespace CheckUpdate
{
     public partial class Var : MaterialSkin.Controls.MaterialForm
    {
        public System.IO.DriveType DriveType { get; }
        public string letterdrive = "";
        public string selected_sfotware_bottom = "";

        private enum WM_DEVICECHANGE
        {
            // full list: https://docs.microsoft.com/en-us/windows/win32/devio/wm-devicechange
            DBT_DEVICEARRIVAL = 0x8000,             // A device or piece of media has been inserted and is now available.
            DBT_DEVICEREMOVECOMPLETE = 0x8004,      // A device or piece of media has been removed.
        }
        private int WmDevicechange = 0x0219; // device change event   

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);        //This allows window default behavior of base class to be executed

            if (m.Msg == WmDevicechange)
            {
                switch ((WM_DEVICECHANGE)m.WParam)
                {
                    case WM_DEVICECHANGE.DBT_DEVICEREMOVECOMPLETE:
                        detect_sdcard();
                        break;
                    case WM_DEVICECHANGE.DBT_DEVICEARRIVAL:
                        detect_sdcard();
                        break;
                }
            }
        }

        public Var()
        {
            InitializeComponent();
            detect_sdcard();
        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static string FormatBytesToHumanReadable(long bytes)
        {
            if (bytes > 1073741824)
                return Math.Ceiling(bytes / 1073741824M).ToString("#,### GB");
            else if (bytes > 1048576)
                return Math.Ceiling(bytes / 1048576M).ToString("#,### MB");
            else if (bytes >= 1)
                return Math.Ceiling(bytes / 1024M).ToString("#,### KB");
            else if (bytes < 0)
                return "";
            else
                return bytes.ToString("#,### B");
        }

        private void detect_sdcard()
        {
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo drive in drives)
            {
                if (drive.VolumeLabel == "UPDATE MIB")
                {
                    if (drive.DriveType == DriveType.Removable)
                    {
                        letterdrive = drive.Name;
                        sdcard_detect.Text = drive.Name;
                        sdcard_size.Visible = true;
                        miejsca.Visible = true;
                        sdcard_size.Text = FormatBytesToHumanReadable(drive.TotalSize);
                        checkSDid.Visible = true;
                        checkSDid.Checked = true;
                        Select_function.Visible = true;
                        what.Visible = true;

                        if (File.Exists(drive.Name+"/metainfo2.txt"))
                        {
                            Console.WriteLine("file exists");
                            string [] ff=File.ReadAllLines(drive.Name + "/metainfo2.txt");
                            vers.Visible = true;
                            ver1.Visible = true;
                            ver2.Visible = true;
                            string Versja_pelna = ff[2];
                            string Versja_numer = ff[3];

                            string[] subs = Versja_pelna.Split('=');
                            string[] subs1 = Versja_numer.Split('=');
                            ver1.Text = subs[1].Replace('"', ' ');
                            ver2.Text = subs1[1].Replace('"', ' ');

                        }

                    }
                    return;
                } 
                else
                {
                    sdcard_detect.Text = "Brak Karty SD";
                    checkSDid.Checked = false;
                    checkSDid.Visible = false;
                    miejsca.Visible = false;
                    sdcard_size.Visible = false;
                    vers.Visible = false;
                    ver1.Visible = false;
                    ver2.Visible = false;
                    what.Visible = false;
                    Select_function.Visible = false;
                    progressDownload.Visible = false;
                    downloadtextFile.Visible = false;
                    progressInstall.Visible = false;
                    downloadInstall.Visible = false;
                    sel_firm.Visible = false;
                    select_firmware.Visible = false;
                    labelPerc.Visible = false;
                    labelSpeed.Visible = false;
                    labelDownloaded.Visible = false;
                    infoFileName_label.Visible = false;
                }
            
                
            }
        }
        public event EventHandler CheckedChanged;

        private void menu_CheckedChanged(object sender, EventArgs e)
        {
            string operation = "";

            if (radiob1.Checked)
            {
                operation = radiob1.Text;
                install_maps();
                what.Visible = true;
                select_firmware.Visible = false;
                sel_firm.Visible = false;
            }

            if (radiob2.Checked)
            {
                what.Visible = true;
                Select_function.Visible = true;
                select_firmware.Visible = true;
                sel_firm.Visible = true;
                selected_sfotware_bottom = (string)select_firmware.SelectedItem;
                selected_software.Text = selected_sfotware_bottom;
                if (selected_sfotware_bottom == null)
                {

                }
                else
                {
                    string curFile = letterdrive + "/" + selected_sfotware_bottom;
                    labelPerc.Visible = true;
                    labelSpeed.Visible = true;
                    labelDownloaded.Visible = true;
                    infoFileName_label.Visible = true;
                    install_firmware();
                    next.Visible = true;
                }

            }

            if (radiob3.Checked)
            {
                operation = radiob3.Text;
                what.Visible = true;
                select_firmware.Visible = false;
                sel_firm.Visible = false;
                install_green();
            }
            //your code
        }

        private void next_Click(object sender, EventArgs e)
        {            
            if(sdcard_format.Checked)
            {
                Format();
            }
        }

        public void Format()
        {
            try
            {
                CheckUpdate.Format.FormatUSB(letterdrive, "FAT32", true, 4096, "UPDATE MIB", false);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }

        private void disable_select()
        {
            what.Visible = false;
            Select_function.Visible = false;
            progressDownload.Visible = false;
            next.Visible = false;
        }

        private void enable_select()
        {
            what.Visible = true;
            Select_function.Visible = true;
            progressDownload.Visible = true;
            next.Visible = true;
        }

        private void install_maps()
        {
            var vw_maps = "";
            MessageBox.Show("ss");
        }

        private void install_firmware()
        {
            var url_file = "http://files.vw-wiki.in/";
            progressInstall.Visible = true;
            downloadInstall.Visible = true;
            infoFileName_label.Visible = true;
            if (select_firmware.SelectedIndex != 0)
            {
                downloadFile(url_file+selected_sfotware_bottom, selected_sfotware_bottom);
            }            
        }

        private void install_green()
        {
            var github_url = "https://github.com/olli991/mib-std2-pq-zr-toolbox/archive/refs/heads/master.zip";
            downloadFile(github_url,"mib_toolbox.zip");
        }

        Stopwatch sw = new Stopwatch();

        public void downloadFile(string sourceURL, string filename="plik.zip")
        {
            progressDownload.Visible = true;
            downloadtextFile.Visible = true;
            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webClient.QueryString.Add("fileName", filename.ToString());
            Application.DoEvents();
            sw.Start();

            try
            {
                progressDownload.Visible = true;
                webClient.DownloadFileAsync(new Uri(sourceURL), letterdrive + @"\" + filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // The event that will fire whenever the progress of the WebClient is changed
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Calculate download speed and output it to labelSpeed.
            labelSpeed.Text = string.Format("{0} kb / s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

            // Update the progressbar percentage only when the value is not the same.
            progressDownload.Value = e.ProgressPercentage;

            // Show the percentage on our label.
            labelPerc.Text = e.ProgressPercentage.ToString() + "%";

            // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
           labelDownloaded.Text = string.Format("{0} MB’s / {1} MB’s",(e.BytesReceived/1024d/1024d).ToString("0.00"), (e.TotalBytesToReceive/1024d/1024d).ToString("0.00"));
        }
        
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                string error = e.Error.ToString();
                MessageBox.Show(error);
                return;
            }
            // Reset the stopwatch.
            sw.Reset();

            if (e.Cancelled == true)
            {
                MessageBox.Show("Download has been canceled.");
            }
            else
            {
                progressDownload.Visible = true;
                progressInstall.Visible = true;
                downloadInstall.Visible = true;
                infoFileName_label.Visible = true;
                labelPerc.Visible = true;
                labelSpeed.Visible = true;
                labelDownloaded.Visible = true;
                string myFileNameID = ((System.Net.WebClient)(sender)).QueryString["fileName"];

                System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
                t.Interval = 1000;
                t.Tick += timeElapsed;
                t.Start();
               
                enable_select();
                CheckUpdate.Unzip.ExtractZip(letterdrive+"/"+ myFileNameID, letterdrive + "/");
            }
        }
        public static bool info;
        internal static int infoProgress;
        internal static string infoFileName;

        private void timeElapsed(object sender, EventArgs e)
        {
            progressInstall.Value = infoProgress;
            infoFileName_label.Text = infoFileName;
            if (info == false)
            {
                downloadInstall.Text = "Rozpakowywanie plików";
            }
            else
            {
                downloadInstall.Text = "Pliki Zostały Rozpakowane";
                infoFileName_label.Visible = false;
            }
        }

    }


}
