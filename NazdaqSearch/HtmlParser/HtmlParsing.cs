using System;
using HtmlAgilityPack;
using System.Collections.Generic;

namespace NazdaqSearch.HtmlParser
{
    public class HtmlParsing 
    {
        public static void OptionsParsing() 
        {
        
            HtmlWeb web = new HtmlWeb();
            HtmlDocument NazDaqPage = web.Load("https://www.nasdaq.com/options/");

            HtmlNodeCollection test = NazDaqPage.DocumentNode.SelectNodes("//b");

            foreach (HtmlNode item in test) 
            {
                String linkTitle = item.InnerHtml;
                String[] linkTitleArray = linkTitle.Split(" ");

                if (linkTitleArray[0] == "Notable" || linkTitleArray[0] == "Noteworthy") {
                    Console.WriteLine(linkTitle);
                }

            }
        }
    }
}