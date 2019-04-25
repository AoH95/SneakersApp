using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SneakersApp.Controllers
{
    public class CollectionController : Controller
    {
        public IActionResult Index()
        {
            var model = new CollectionIndexModel()
            {

            };
            return View(model);
        }
    }
}