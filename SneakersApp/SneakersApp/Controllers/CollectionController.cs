using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using SneakersApp.Models;
using SneakersApp.Services;
using SneakersApp.Data;
using SneakersApp.Data.Models;

namespace SneakersApp.Controllers
{
    public class CollectionController : Controller
    {
        private readonly ICollection _collectionService;

        public CollectionController(ICollection collectionService)
        {
            _collectionService = collectionService;
        }

        public IActionResult Index()
        {
            var collectionList = _collectionService.GetAll();

            var model = new CollectionIndexModel()
            {
                Collection = collectionList,
                SearchQuery = ""
            };
            return View(model);
        }
    }
}