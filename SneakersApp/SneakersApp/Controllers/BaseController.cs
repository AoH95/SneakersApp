using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SneakersApp.Class;
using SneakersApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetEtMechant.Controllers
{
    public class BaseController : Controller
    {
        protected readonly SneakersAppDbContext _context;
        public BaseController(SneakersAppDbContext context)
        {
            _context = context;
        }

        protected void DisplayMessage(string message, TypeMessage typeMessage)
        {
            TempData["Message"] = JsonConvert.SerializeObject(new FlashMessage(message, typeMessage));
        }
    }
}
