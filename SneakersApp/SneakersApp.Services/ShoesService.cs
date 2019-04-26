﻿using System;
using System.Collections.Generic;
using SneakersApp.Data;
using SneakersApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Threading.Tasks;

namespace SneakersApp.Services
{
    public class ShoesService : IImage
    {
        private readonly SneakersAppDbContext _ctx;
        public ShoesService(SneakersAppDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Shoes> GetAll()
        {
            return _ctx.Shoes.Include(img => img.Tags);
        }

        public Shoes GetById(int id)
        {
            return GetAll().Where(img => img.Id == id).First();
        }

        public IEnumerable<Shoes> GetWithTag(string tag)
        {
            return GetAll().Where(img => img.Tags.Any(t => t.Description == tag));
        }

        public CloudBlobContainer GetBlobContainer(string azureConnectionString, string containerName)
        {
            var storageAccount = CloudStorageAccount.Parse(azureConnectionString);
            var blobClient = storageAccount.CreateCloudBlobClient();
            return blobClient.GetContainerReference(containerName);
        }

        public async Task SetShoe(string title, string tags, Uri uri)
        {
            var shoe = new Shoes
            {
                Title = title,
                Tags = ParseTags(tags),
                Url = uri.AbsoluteUri,
                Created = DateTime.Now
            };

            _ctx.Add(shoe);
            await _ctx.SaveChangesAsync();
        }

        public List<Tag> ParseTags(string tags)
        {
            return tags.Split(",").Select(tag => new Tag
            {
                Description = tag
            }).ToList();
        }
    }
}
