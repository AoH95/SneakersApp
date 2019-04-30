using System;
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
    public class ShoesService : IShoe
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
        public IEnumerable<Shoes> GetAllByUser(string id)
        {
            return _ctx.Shoes.Where(shoe => shoe.UserId == id);
        }

        public IEnumerable<Shoes> GetAllByCollection(string id)
        {
            return _ctx.Shoes.Where(shoe => shoe.CollectionID == id);
        }

        public Shoes GetById(int id)
        {
            return GetAll().Where(img => img.Id == id).First();
        }

        public IEnumerable<Shoes> GetWithTag(string tag)
        {
            return GetAll().Where(img => img.Tags.Any(t => t.Description == tag));
        }

        public async Task DeleteShoe(Shoes shoe)
        {
            _ctx.Remove(shoe);
            await _ctx.SaveChangesAsync();
        }

        public async Task PutShoe(int id, Shoes shoe)
        {
            _ctx.Entry(shoe).State = EntityState.Modified;
            try
            {
                await _ctx.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoeExists(id))
                {
                    return;
                }
                else
                {
                    throw;
                }
            }
            return;

        }

        public CloudBlobContainer GetBlobContainer(string azureConnectionString, string containerName)
        {
            var storageAccount = CloudStorageAccount.Parse(azureConnectionString);
            var blobClient = storageAccount.CreateCloudBlobClient();
            return blobClient.GetContainerReference(containerName);
        }

        public async Task createShoe(string title, string tags, Uri uri, string id, string description, string CollectionsID)
        {
            var shoe = new Shoes
            {
                Title = title,
                Tags = ParseTags(tags),
                Url = uri.AbsoluteUri,
                Created = DateTime.Now,
                UserId = id,
                Description = description,
                CollectionID = CollectionsID
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

        private bool ShoeExists(int id)
        {
            return _ctx.Shoes.Any(e => e.Id == id);
        }

    }
}
