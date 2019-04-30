using SneakersApp.Class;
using SneakersApp.Controllers;
using SneakersApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersApp.Areas.Administration.Controllers
{
    [Area("Administration")]
    [Authorize]
    public abstract class BaseAdminController : BaseController
    {
        public BaseAdminController(SneakersAppDbContext context) : base(context)
        {
        }


    }
}
