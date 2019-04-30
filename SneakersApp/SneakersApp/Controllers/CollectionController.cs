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
using Microsoft.AspNetCore.Identity;
using SneakersApp.Data.Models;

namespace SneakersApp.Controllers
{
    public class CollectionController : BaseController
    {
        private readonly ICollection _collectionService;
        private readonly IShoe _shoeService;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
       
        public CollectionController(ICollection collectionService, IShoe shoeService, UserManager<User> userManager, SignInManager<User> signInManager, SneakersAppDbContext context) : base(context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _collectionService = collectionService;
            _shoeService = shoeService;
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

        public IActionResult Usercollection()
        {
            var idUser = _userManager.GetUserId(User);
            var collectionList = _collectionService.GetAllByUser(idUser);

            var model = new CollectionIndexModel()
            {
                Collection = collectionList,
                SearchQuery = ""
            };

            return View(model);
        }

        public IActionResult Create()
        {
            var model = new CreateCollectionModel();
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var collection = _collectionService.GetById(id);
            var shoes = _shoeService.GetAllByCollection(id.ToString());
            var model = new CollectionDetailModel()
            {
                Id = id,
                Title = collection.Title,
                Shoes = shoes
            };

            return View(model);
        }
        public IActionResult Update(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var idUser = _userManager.GetUserId(User);
            var collection = _collectionService.GetById(id);
            if (collection == null)
            {
                return NotFound();
            }
            var model = new CreateCollectionModel()
            {
                Id = id
            };

            return View(model);
        }
        public async Task<IActionResult> UpdateCollection(int id, Collection collection)
        {
            if (id != collection.Id)
            {
                return BadRequest();
            }
            await _collectionService.PutCollection(id, collection);
            return RedirectToAction("Index", "Collection");
        }

        [HttpPost]
        public async Task<IActionResult> createCollection(string title, string description)
        {
            var idUser = _userManager.GetUserId(User);
            await _collectionService.createCollection(title, description, idUser);

            return RedirectToAction("Index", "Collection");
        }
        public async Task<IActionResult> Delete(int id)
        {
            var collection = _collectionService.GetById(id);

            if (collection == null)
            {
                return NotFound();
            }
            await _collectionService.DeleteCollection(collection);
            return RedirectToAction("Index", "Collection");
        }
    }
}