using ComicBookStore.DL.Interfaces;
using ComicBookStore.DL.MemoryDb;
using ComicBookStore.Models.Models.Users;

namespace ComicBookStore.DL.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public List<Author> GetAll()
        {
            return InMemoryDb.AuthorsData;
        }

        public Author GetById(int id)
        {
            return InMemoryDb.AuthorsData
                .First(a => a.Id == id);
        }

        public void Add(Author author)
        {
            InMemoryDb.AuthorsData.Add(author);
        }

        public void Remove(int id)
        {
            var author = GetById(id);
            InMemoryDb.AuthorsData.Remove(author);
        }
    }
}
