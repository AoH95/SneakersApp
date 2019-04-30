﻿using System;
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
using Microsoft.AspNetCore.Identity;
using SneakersApp.Data.Models;

namespace SneakersApp.Controllers
{
    public class CollectionController : BaseController
    {
        private readonly ICollection _collectionService;
        private readonly UserManager<User> _userManager;
        public CollectionController(ICollection collectionService, UserManager<User> userManager, SneakersAppDbContext context) : base(context)
        {
            _userManager = userManager;
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

        public IActionResult UserCollection()
        {
            var idUser = _userManager.GetUserId(User);
            var collectionList = _collectionService.GetAllByUser(idUser);
            return View();
        }
    }
}