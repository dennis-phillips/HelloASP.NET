using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelloASP.NET.Controllers
{
    [Route("/helloworld/")]
    public class HelloController : Controller
    {
        [HttpGet]
        
        public IActionResult Index()
        {
            
            return View();
        }

        //GET: /hello/welcome
        //[HttpGet]
        //[Route("/hello/welcome/{name?}")]
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        
        public IActionResult Welcome(string name = "Whoever you are")
        {
            ViewBag.person = name;
            return View();
        }

        [HttpPost("/CreateMessage/")]
        public IActionResult CreateMessage( string name, string language= "English")
        {
            string html = language + name;
            return Content(html, "text/html");
        }
    }
}
