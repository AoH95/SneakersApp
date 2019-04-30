using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SneakersApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SneakersApp.Areas.Administration.Controllers
{

    public class DashboardController : BaseAdminController
    {
        public DashboardController(SneakersAppDbContext context) : base(context)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}