using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Security.Permissions;
using System.Windows.Forms;

public class Sdcard
{
    public static int FormatDrive(string driveLetter)
	{
        string FileSystem = "FAT32", Label = "UPDATE MIB";
        Boolean QuickFormat = true, EnableCompression = false;
        UInt32 ClusterSize = 32 * 1024;
        int result = -1;

        ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_Volume WHERE DriveLetter = '" + driveLetter + "'");
        ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
        foreach (ManagementObject management in searcher.Get())
        {
            Console.WriteLine("Formating disk " + driveLetter + "...");
            result = Convert.ToInt32(management.InvokeMethod("Format", new object[] { FileSystem, QuickFormat, ClusterSize, Label, EnableCompression }));
        }
        Console.WriteLine(result);
        return result;
    }
}
