using BookStore.DL.Configs;
using BookStore.DL.Interfaces;
using BookStore.Models.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BookStore.DL.Repositories.Mongo
{
    public class AuthorRepositoryMongo : IAuthorRepository
    {
        private readonly IMongoCollection<Author> _Authors;
        public IOptionsMonitor<MongoConfiguration> _mongoConfig;
        public AuthorRepositoryMongo(IOptionsMonitor<MongoConfiguration> mongoConfig)
        {
            _mongoConfig = mongoConfig;

            var clinet = new MongoClient(mongoConfig.CurrentValue.ConnectionString);
            var db = clinet.GetDatabase(mongoConfig.CurrentValue.DatabaseName);
            _Authors = db.GetCollection<Author>("Authors");
        }
        public async Task AddAuthor(Author Author)
        {
            await _Authors.InsertOneAsync(Author);
        }

        public async Task DeleteAuthor(int id)
        {
            await _Authors.DeleteOneAsync(b => b.Id == id);
        }

        public async Task<List<Author>> GetAllAuthors()
        {
            return await _Authors.Find(b => true).ToListAsync();
        }

        public async Task<Author?> GetAuthor(int id)
        {
            var result = await _Authors.FindAsync(b => b.Id == id);
            return result.FirstOrDefault();
        }

        public async Task UpdateAuthor(Author Author)
        {
            await _Authors.ReplaceOneAsync(b => b.Id == Author.Id, Author);
        }
    }
}
