using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
            /*
             * la convenzione di questa scrittura prevede che
             * venga ritornata la view con lo stesso nome del 
             * metodo che la richiama (in questo caso Index)
            */
        }

        public IActionResult Detail(string id)
        {
            return View();
        }

        public IActionResult Search(string title)
        {
            return View();
        }
    }
}
