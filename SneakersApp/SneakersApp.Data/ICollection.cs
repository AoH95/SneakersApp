using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SneakersApp.Data.Models;

namespace SneakersApp.Data
{
    public interface ICollection
    {
        IEnumerable<Collection> GetAll();
        IEnumerable<Collection> GetAllByUser(string id);
        Collection GetById(int id);
        Task createCollection(string title, string description, string id);
        Task DeleteCollection(Collection collection);
        Task PutCollection(int id, Collection collection);
    }
}
