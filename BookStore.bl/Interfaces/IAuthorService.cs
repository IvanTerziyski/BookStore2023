using BookStore.Models.Models;

namespace BookStore.BL.Interfaces
{
    public interface IAuthorService
    {
        public void AddAuthor(Author author);

        public void DeleteAuthor(int id);

        public void UpdateAuthor(Author author);


        public Author? GetAuthor(int id);


        public List<Author> GetAllAuthors();
    }
}
