using System.Collections.Generic;
using SneakersApp.Data.Models;

namespace SneakersApp.Data
{
    public interface IImage
    {
        IEnumerable<Shoes> GetAll();
        IEnumerable<Shoes> GetWithTag(string tag);
        Shoes GetById(int id);
    }
}
