using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.IO;

namespace Probalasok
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            Console.WriteLine("Detected Drives: ");
            for (int i = 0; i < drives.Count(); i++)
            {
                Console.WriteLine(drives[i].Name +" "+  drives[i].DriveType);
            }

            string rootDrive = Path.GetPathRoot(Environment.SystemDirectory);
            var rootOfCurrentPath = Path.GetPathRoot(Environment.CurrentDirectory);
            var driveWhereWindowsIsInstalled = Path.GetPathRoot(Environment.SystemDirectory);

            

            Console.ReadLine();
        }
    }
}
