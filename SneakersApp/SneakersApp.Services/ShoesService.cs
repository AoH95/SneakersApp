using System;
using System.Collections.Generic;
using SneakersApp.Data;
using SneakersApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SneakersApp.Services
{
    public class ImageService : IImage
    {
        private readonly SneakersAppDbContext _ctx;
        public ImageService(SneakersAppDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Shoes> GetAll()
        {
            return _ctx.Shoes.Include(img => img.Tags);
        }

        public Shoes GetById(int id)
        {
            return _ctx.Shoes.Find(id);
        }

        public IEnumerable<Shoes> GetWithTag(string tag)
        {
            return GetAll().Where(img => img.Tags.Any(t => t.Description == tag));
        }
    }
}
