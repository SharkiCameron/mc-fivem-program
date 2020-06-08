using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace FiveM_File_Downloader
{
    class Program
    {

        static void Main(string[] args)
        {
            String dlink = "https://pastebin.com/raw/vJif4N7m";
            String pname = "FiveM-Files-Downloader";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Downloading files");
            WebClient wc = new WebClient();
            String key = wc.DownloadString(dlink);
            String path = @"Files\" + pname + ".rar";
            System.Net.WebClient Dow = new WebClient();
            String patch = (@"Files");
            Directory.CreateDirectory(patch);
            Dow.DownloadFile(key, path);
            Console.WriteLine("Files are now downloaded");
        }
    }
}
