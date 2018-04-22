using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using multiplos_mvc.Models;

namespace multiplos_mvc.Controllers
{
    public class ActionsController : Controller
    {
        public IActionResult Index()
        {
            Multiplos multiplos = new Multiplos();
           
            return View(multiplos.listarMultiplos());
       }
    }
}
