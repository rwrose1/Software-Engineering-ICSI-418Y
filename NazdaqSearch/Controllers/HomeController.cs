using Microsoft.AspNetCore.Mvc;
using NazdaqSearch.HtmlParser;

namespace NazdaqSearch.Controllers{
 
    public class HomeController : Controller{
        
        public IActionResult Index(){
            
            HtmlParsing.OptionsParsing();
            return View();
        }
    
    }

}