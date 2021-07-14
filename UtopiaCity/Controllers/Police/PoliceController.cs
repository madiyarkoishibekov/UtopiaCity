using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UtopiaCity.Controllers.Police
{
    public class PoliceController : Controller
    {
        public IActionResult PoliceMain()
        {
            return View();
        }
    }
}