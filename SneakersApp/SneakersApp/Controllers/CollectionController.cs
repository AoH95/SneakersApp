using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SneakersApp.Models;
using SneakersApp.Data.Models;
using SneakersApp.Data;

namespace SneakersApp.Controllers
{
    public class CollectionController : Controller
    {
        private readonly IImage _shoesService;

        public CollectionController(IImage shoesService)
        {
            _shoesService = shoesService;
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

            var model = new CollectionIndexModel()
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
    }
}   