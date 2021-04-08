using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BYUEgyptExcavation.Controllers
{
    public class ResearcherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
