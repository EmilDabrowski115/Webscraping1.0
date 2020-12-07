
using System;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;
using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using System.Collections.Generic;
using System.Text;  // For class Encoding
using System.IO;    // For StreamReader
using System.Diagnostics;

namespace GPUwebscraping
{
    class Program
    {

        private static readonly WebClient client = new WebClient();

        static void Main(string[] args)
        {


            String url1 = "https://www.newegg.com/msi-geforce-rtx-3080-rtx3080-suprim-x-10g/p/N82E16814137609";
            String url2 = "https://www.x-kom.pl/p/600904-karta-graficzna-nvidia-msi-geforce-rtx-3080-suprim-x-10gb-gddr6x.html";
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                String responseString1 = client.DownloadString(url1);
                var htmlDoc = new HtmlDocument();
                htmlDoc.LoadHtml(responseString1);
                HtmlNode node = htmlDoc.QuerySelector(".product-inventory > strong");
                Console.WriteLine("newegg msi Rtx 3080 Suprim X 10GB = " + node.InnerText);
                if (node.InnerText != " OUT OF STOCK.")

                /*    System.Threading.Thread.Sleep(1000);
                String responseString2 = client.DownloadString(url2);
                var htmlDoc2 = new HtmlDocument();
                htmlDoc.LoadHtml(responseString2);
                HtmlNode node2 = htmlDoc2.QuerySelector(".sc-1smss4h-5 gllTln > span ");
                Console.WriteLine("Xkom msi RTX 3080 suprim x = " + node2.InnerText);
                if (node.InnerText != "Zapytaj o dostępność") */

                {
                   

                    while (true)
                    {
                        Process.Start("cmd.exe", "/C start chrome https://www.newegg.com/msi-geforce-rtx-3080-rtx3080-suprim-x-10g/p/N82E16814137609");
                        Console.Write("\a");
                        Console.WriteLine("newegg msi Rtx 3080 Suprim X 10GB = " + node.InnerText);
                        System.Threading.Thread.Sleep(1000);
                        /*
                        Process.Start("cmd.exe", "/C start chrome https://www.x-kom.pl/p/600904-karta-graficzna-nvidia-msi-geforce-rtx-3080-suprim-x-10gb-gddr6x.html");
                        Console.Write("\a");
                        Console.WriteLine("Xkom Karta graficzna dostepna = " + node.InnerText);
                        System.Threading.Thread.Sleep(1000);
                    }
                }
            }


            

           
        }
    }
}