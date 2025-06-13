using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace Persistence
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(IConfiguration configuration)
        {
            var mongoClient = new MongoClient(configuration.GetConnectionString("MongoConnection"));
            _database = mongoClient.GetDatabase("ReadModelDb");
        }

        // public IMongoCollection<ProductReadModel> Products =>
        //     _database.GetCollection<ProductReadModel>("Products");

        // Thêm các collection khác nếu cần
    }
}
