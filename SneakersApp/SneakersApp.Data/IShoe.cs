using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Blob;
using SneakersApp.Data.Models;

namespace SneakersApp.Data
{
    public interface IShoe
    {
        IEnumerable<Shoes> GetAll();
        IEnumerable<Shoes> GetAllByUser(string id);
        IEnumerable<Shoes> GetWithTag(string tag);
        IEnumerable<Shoes> GetAllByCollection(string id);
        Shoes GetById(int id);
        CloudBlobContainer GetBlobContainer(string connectionString, string containerName);
        Task createShoe(string title, string tags, Uri uri, string id, string description);
        List<Tag> ParseTags(string tags);
        Task DeleteShoe(Shoes shoe);
        Task PutShoe(int id, Shoes shoe);
    }
}
