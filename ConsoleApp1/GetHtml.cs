using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;

namespace ConsoleApp1
{
    class GetHtml
    {
        public string FileName { get; set; }
        public void getHtml(string url)
        {
            _getHtml(url);
        }


        private void _getHtml(string url)
        {
            try
            {
                HtmlWeb webpage = new HtmlWeb();
                HtmlDocument webdoc = webpage.Load(url);
                webdoc.Save(FileName);
            }
            catch(UriFormatException e)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
