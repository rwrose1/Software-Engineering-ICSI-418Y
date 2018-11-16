using Microsoft.AspNetCore.Mvc;
using NazdaqSearch.Logic.HtmlParser;
using System.Collections.Generic;
using NazdaqSearch.Models;
using NazdaqSearch.Logic.NazdaqCSV;

namespace NazdaqSearch.Controllers{
 
    public class HomeController : Controller{
        
        public ActionResult Index(){

            List<NazdaqData> display = HtmlParsing.getData();

            NazdaqCSV.dataToCSV(display);

            return View(display);
        
        }

        public ViewResult Contact() {

            return View();

        }
    
    }

}