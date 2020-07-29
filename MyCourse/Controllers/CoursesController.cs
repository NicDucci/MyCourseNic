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
            return Content("Sono Index");
        }

        public IActionResult Detail(string id)
        {
            return Content($"Sono Detail, ho ricevuto l'Id {id}.");
        }

        public IActionResult Search(string title)
        {
            return Content($"Sono Search, hai cercato il corso {title}.");
        }
    }
}
