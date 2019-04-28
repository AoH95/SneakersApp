using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SneakersApp.Data.Models;

namespace SneakersApp.Data
{
    public interface ICollection
    {
        IEnumerable<Collection> GetAll();
        Collection GetById(int id);
        Task createCollection(Collection collection);
        Task Delete(Collection collection);
        Task PutCollection(int id, Collection collection);
    }
}
