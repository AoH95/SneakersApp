using System;
using System.Collections.Generic;
using SneakersApp.Data;
using SneakersApp.Data.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SneakersApp.Services
{
    public class CollectionsService : ICollection
    {
        private readonly SneakersAppDbContext _ctx;
        public CollectionsService(SneakersAppDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Collection> GetAll()
        {
            return _ctx.Collections;
        }
        public IEnumerable<Collection> GetAllByUser(string id)
        {
            return _ctx.Collections.Where(collection => collection.UserId == id);
        }
        public Collection GetById(int id)
        {
            return GetAll().Where(collection => collection.Id == id).First();
        }
        public async Task DeleteCollection(Collection collection)
        {
            _ctx.Remove(collection);
            await _ctx.SaveChangesAsync();
        }
        private bool CollectionExists(int id)
        {
            return _ctx.Collections.Any(e => e.Id == id);
        }

        public async Task createCollection(string title, string description, string id)
        {
            var collection = new Collection
            {
                Title = title,
                Description = description,
                Created = DateTime.Now,
                UserId = id
            };

            _ctx.Add(collection);
            await _ctx.SaveChangesAsync();
        }

        public Task PutCollection(int id, Collection collection)
        {
            throw new NotImplementedException();
        }
    }
}
