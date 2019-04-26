using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Blob;
using SneakersApp.Data.Models;

namespace SneakersApp.Data
{
    public interface IImage
    {
        IEnumerable<Shoes> GetAll();
        IEnumerable<Shoes> GetWithTag(string tag);
        Shoes GetById(int id);
        CloudBlobContainer GetBlobContainer(string connectionString, string containerName);
        Task SetShoe(string title, string tags, Uri uri);
        List<Tag> ParseTags(string tags);
    }
}
