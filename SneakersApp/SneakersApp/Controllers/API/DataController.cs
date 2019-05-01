using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SneakersApp.Models;

namespace SneakersApp.Controllers.API
{
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = SneakersJWTTokens.AuthSchemes)]
    public class DataController : Controller
    {
        [HttpGet]
        public List<string> GetData()
        {
            return new List<string>() { "data1", "data2"};
        }
    }
}