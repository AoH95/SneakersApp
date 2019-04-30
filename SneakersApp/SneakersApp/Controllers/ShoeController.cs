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

namespace SneakersApp.Controllers
{
    public class ShoeController : BaseController
    {
        private readonly IShoe _shoesService;
        private IConfiguration _config;
        private readonly UserManager<User> _userManager;

        private string AzureConnectionString { get; }

        public ShoeController(IShoe shoesService, IConfiguration config, SneakersAppDbContext context, UserManager<User> userManager) : base(context)
        {
            _userManager = userManager;
            _shoesService = shoesService;
            _config = config;
            AzureConnectionString = _config["AzureStorageConnectionString"];
        }

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

        public IActionResult Create()
        {
            var model = new UploadShoeModel();
            return View(model);
        }

        public IActionResult Update(int id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var shoe = _shoesService.GetById(id);
            if(shoe == null)
            {
                return NotFound();
            }
            var model = new UploadShoeModel() {
                   Id = shoe.Id
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UploadNewShoe(IFormFile file, string tags, string title)
        {
            var container = _shoesService.GetBlobContainer(AzureConnectionString, "images");
            var content = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
            var fileName = content.FileName.Trim('"');
            var idUser = _userManager.GetUserId(User);
            var blockBlob = container.GetBlockBlobReference(fileName);

            await blockBlob.UploadFromStreamAsync(file.OpenReadStream());
            await _shoesService.createShoe(title, tags, blockBlob.Uri, idUser);

            return RedirectToAction("Index", "Shoe");
        }

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

        public async Task<IActionResult> UpdateShoe(int id, Shoes shoe)
        {
            if (id != shoe.Id)
            {
                return BadRequest();
            }
            await _shoesService.PutShoe(id, shoe);
            return RedirectToAction("Index", "Shoe");
        }
        public IActionResult Usershoe()
        {
            var idUser = _userManager.GetUserId(User);
            var shoesList = _shoesService.GetAllByUser(idUser);
            var model = new ShoeIndexModel()
            {
                Shoes = shoesList,
                SearchQuery = idUser
            };
            return View(model);
        }
    }
}   