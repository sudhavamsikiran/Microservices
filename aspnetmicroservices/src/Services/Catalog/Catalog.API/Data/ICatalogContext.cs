using Catalog.API.Entities;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
namespace Catalog.API.Data
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
