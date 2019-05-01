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
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace SneakersApp.Controllers.API
{
    public class ShoeController : BaseController
    {
        private readonly IShoe _shoesService;
        private readonly ICollection _collectionService;
        private IConfiguration _config;
        private readonly UserManager<User> _userManager;
        private string AzureConnectionString { get; }

        public ShoeController(IShoe shoesService, ICollection collectionService,  IConfiguration config, SneakersAppDbContext context, UserManager<User> userManager) : base(context)
        {
            _userManager = userManager;
            _shoesService = shoesService;
            _config = config;
            _collectionService = collectionService;
            AzureConnectionString = _config["AzureStorageConnectionString"];
        }

        //[Authorize(Roles = "SuperAdmin, Admin, Visiteur")]
        //[Authorize(Policy = "2000")]

        [Route("[controller]/[action]")]
        [Authorize(AuthenticationSchemes = SneakersJWTTokens.AuthSchemes)]
        public IActionResult Index() 
        {
            // Mock datas
            /* var shoesImageTags = new List<Tag>();

            var tag1 = new Tag()
            {
                Description = "Les vrais bails",
                Id = 0
            };

            var tag2 = new Tag()
            {
                Description = "Les bons bails",
                Id = 1
            };

            shoesImageTags.AddRange(new List<Tag>{ tag1, tag2});

            var shoesList = new List<Shoes>()
            {
                new Shoes()
                {
                    Title = "Nike SB",
                    Url = "https://images.pexels.com/photos/1598505/pexels-photo-1598505.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                    Created = DateTime.Now,
                    Tags = shoesImageTags
                },
                new Shoes()
                {
                    Title = "Nike SB 2",
                    Url = "https://images.pexels.com/photos/1598505/pexels-photo-1598505.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                    Created = DateTime.Now,
                    Tags = shoesImageTags
                },
                new Shoes()
                {
                    Title = "Nike SB 3",
                    Url = "https://images.pexels.com/photos/2065695/pexels-photo-2065695.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                    Created = DateTime.Now,
                    Tags = shoesImageTags
                }
            }; */

            var shoesList = _shoesService.GetAll();

            var model = new ShoeIndexModel()
            {
                Shoes = shoesList,
                SearchQuery = ""
            };
            return View(model);
        }

        [Route("[controller]/[action]")]
        [Authorize(AuthenticationSchemes = SneakersJWTTokens.AuthSchemes)]
        public IActionResult Detail(int id)
        {
            var shoes = _shoesService.GetById(id);

            var model = new ShoesDetailModel()
            {
                Id = shoes.Id,
                Title = shoes.Title,
                Created = shoes.Created,
                Url = shoes.Url,
                Tags = shoes.Tags.Select(t => t.Description).ToList()
            };

            return View(model);
        }

        [Route("[controller]/[action]")]
        [Authorize(AuthenticationSchemes = SneakersJWTTokens.AuthSchemes)]
        public IActionResult Create()
        {
            var idUser = _userManager.GetUserId(User);
            var collections = _collectionService.GetAllByUser(idUser);
            var model = new UploadShoeModel() {
                Collections = collections
            };
            return View(model);
        }

        public IActionResult Update(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var idUser = _userManager.GetUserId(User);
            var collections = _collectionService.GetAllByUser(idUser);
            var shoe = _shoesService.GetById(id);
            if(shoe == null)
            {
                return NotFound();
            }
            var model = new UploadShoeModel() {
                Id = shoe.Id,
                Collections = collections
            };
            return View(model);
        }

        [HttpPost]
        [Route("api/[controller]/[action]")]
        [Authorize(AuthenticationSchemes = SneakersJWTTokens.AuthSchemes)]
        public async Task<IActionResult> UploadNewShoe(IFormFile file, string tags, string title, string description, string CollectionsID)
        {
            var container = _shoesService.GetBlobContainer(AzureConnectionString, "images");
            var content = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
            var fileName = content.FileName.Trim('"');
            var idUser = _userManager.GetUserId(User);
            var blockBlob = container.GetBlockBlobReference(fileName);

            await blockBlob.UploadFromStreamAsync(file.OpenReadStream());
            await _shoesService.createShoe(title, tags, blockBlob.Uri, idUser, description, CollectionsID);

            return RedirectToAction("Index", "Shoe");
        }

        [Route("api/[controller]/[action]")]
        [Authorize(AuthenticationSchemes = SneakersJWTTokens.AuthSchemes)]
        public async Task<IActionResult> Delete(int id)
        {
            var shoe = _shoesService.GetById(id);

            if (shoe == null)
            {
                return NotFound();
            }
            await _shoesService.DeleteShoe(shoe);
            return RedirectToAction("Index", "Shoe");
        }

        [Route("api/[controller]/[action]")]
        [Authorize(AuthenticationSchemes = SneakersJWTTokens.AuthSchemes)]
        public async Task<IActionResult> UpdateShoe(int id, Shoes shoe)
        {
            if (id != shoe.Id)
            {
                return BadRequest();
            }
            await _shoesService.PutShoe(id, shoe);
            return RedirectToAction("Index", "Shoe");
        }

        [Route("[controller]/[action]")]
        [Authorize(AuthenticationSchemes = SneakersJWTTokens.AuthSchemes)]
        public IActionResult Usershoe()
        {
            var idUser = _userManager.GetUserId(User);
            var shoesList = _shoesService.GetAllByUser(idUser);
            var model = new ShoeIndexModel()
            {
                Shoes = shoesList,
                SearchQuery = ""
            };
            return View(model);
        }
    }
}   