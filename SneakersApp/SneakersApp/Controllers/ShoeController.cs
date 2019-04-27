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
    public class ShoeController : Controller
    {
        private IConfiguration _config;
        private IImage _shoesService;
        private string AzureConnectionString { get; }

        public ShoeController(IConfiguration config, IImage shoesservice)
        {
            _config = config;
            _shoesService = shoesservice;
            AzureConnectionString = _config["AzureStorageConnectionString"];
        }

        public IActionResult Upload()
        {
            var model = new UploadShoeModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UploadNewShoe(IFormFile file, string tags, string title)
        {
            var container = _shoesService.GetBlobContainer(AzureConnectionString, "images");
            var content = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
            var fileName = content.FileName.Trim('"');

            var blockBlob = container.GetBlockBlobReference(fileName);

            await blockBlob.UploadFromStreamAsync(file.OpenReadStream());
            await _shoesService.createShoe(title, tags, blockBlob.Uri);

            return RedirectToAction("Index", "Collection");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var shoe = _shoesService.GetById(id);

            if (shoe == null)
            {
                return NotFound();
            }
            _shoesService.Delete(shoe);
            return RedirectToAction("Index", "Collection");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateShoe(int id, Shoes shoe)
        {
            if (id != shoe.Id)
            {
                return BadRequest();
            }
            _shoesService.PutShoe(id, shoe);
            return RedirectToAction("Index", "Collection");
        }
    }
}