using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ManagementObjectSearcher searcher = new ManagementObjectSearcher
                 ("SELECT * FROM Win32_LogicalDisk");
             foreach(ManagementObject obj in searcher.Get())
             {
                 Console.WriteLine("Name: " + obj["DeviceID"]);
                 Console.WriteLine("Description: " + obj["Description"]);
                 Console.WriteLine("Free Space: " + Convert.ToDouble(obj["FreeSpace"])
                     / (1024 * 1024 * 1024));
                 Console.WriteLine("Disk size: " + Convert.ToDouble( obj["Size"])
                     /(1024 * 1024 * 1024));

             }*/
            //---------------------------
            /* ManagementObjectSearcher searcher = new ManagementObjectSearcher
                 ("SELECT * FROM Win32_CDROMDrive");
             foreach (ManagementObject obj in searcher.Get())
             {
                 Console.WriteLine("Description: " + obj["Description"]);
                 Console.WriteLine("Drive: " + obj["Drive"]);
                 Console.WriteLine("Media Type: " + obj["MediaType"]);
                 Console.WriteLine("Disk size: " + obj["Size"]);
                 Console.WriteLine("Transfer Rate: " + obj["TransferRate"]);
             }*/
            //----------------------------
            /*ManagementObjectSearcher searcher = new ManagementObjectSearcher
                ("SELECT * FROM Win32_BootConfiguration");
            foreach (ManagementObject obj in searcher.Get())
            {
                Console.WriteLine("Boot Directory: " + obj["BootDirectory"]);
                Console.WriteLine("Description: " + obj["Description"]);
                Console.WriteLine("Scratch Directory: " + obj["ScratchDirectory"]);
                Console.WriteLine("TempDirectory: " + obj["TempDirectory"]);

            }*/
            //--------------------------------
          /*  ManagementObjectSearcher searcher = new ManagementObjectSearcher
                ("SELECT * FROM Win32_Share");
            foreach (ManagementObject obj in searcher.Get())
            {
                Console.WriteLine("Name: " + obj["Name"]);
                Console.WriteLine("Path: " + obj["path"]);
                Console.WriteLine("Description: " + obj["Description"]);
            }*/
            //mariam mohamed Ahmed
        
        }
    }
}

