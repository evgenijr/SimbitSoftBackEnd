using System;
using System.Net;
using HtmlAgilityPack;

namespace ConsoleApp1
{
    class Programs
    {
        static void Main(string[] args)
        {
            Programs program = new Programs();
            Console.WriteLine("Enter URL:");
            program.start(Console.ReadLine());
            
        }
        public void start(string url)
        {
            GetHtml gthmtl = new GetHtml();
            gthmtl.FileName = "test.html";  //name of file
            gthmtl.getHtml(url);            //get html page and save
            HtmlDocument doc = new HtmlDocument();
            doc.Load(gthmtl.FileName);      //get saved file
            HtmlAnalyze htmlAnalyze = new HtmlAnalyze();
            htmlAnalyze.analyze(doc);      //analysis of the saved file 
        }

    } 
}
