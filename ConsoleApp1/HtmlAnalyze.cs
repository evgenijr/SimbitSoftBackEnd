using System;
using System.Linq;
using HtmlAgilityPack;

namespace ConsoleApp1
{
    class HtmlAnalyze
    {
        private char[] ch = { ' ', ',', '.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t' };
        public void analyze(HtmlDocument doc)
        {
            _analyze(doc);
        }

        private void _analyze(HtmlDocument doc)
        {
            string[] str = doc.DocumentNode.InnerText.Split(ch, StringSplitOptions.RemoveEmptyEntries);
            var result=str.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => new { Word = x.Key, Frequency = x.Count() });
            foreach (var item in result)
            {
                Console.WriteLine("{0}-{1}", item.Word, item.Frequency);
            }
        }
    }
}
