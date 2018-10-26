using System;
using HtmlAgilityPack;
using System.Collections.Generic;

namespace NazdaqSearch.HtmlParser
{
    public class HtmlParsing {

        public static void testParser() {
        
            HtmlWeb web = new HtmlWeb();
            HtmlDocument NazDaqPage = web.Load("https://www.nasdaq.com/options/");

            HtmlNodeCollection test = NazDaqPage.DocumentNode.SelectNodes("//b");

            foreach (HtmlNode item in test) {
                Console.WriteLine(item.InnerHtml);
            }
        }
    }

}