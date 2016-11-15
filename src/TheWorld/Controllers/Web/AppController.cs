using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TheWorld.Controllers.Web
{
    public class AppController :Controller
    {
        //<address>/Index
        public IActionResult Index()
        {
            // return a simple html view
            // Views/App/Index.cshtml
            return View();
            /* look in a folder Views for another folder for a corresponding controller
             and view that matches the method's name
             for instance, if controller is AppleController, then looks in a folder
             name Views/Apple/Index.cshtml 
             */
        }

        // <address>/app/Contact
        public IActionResult Contact()
        {
            return View();
        }

        // <address>/app/About
        public IActionResult About()
        {
            return View();
        }


    }
}
