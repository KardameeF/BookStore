using ComicBookStore.DL.Interfaces;
using ComicBookStore.DL.MemoryDb;
using ComicBookStore.Models.Models;

namespace ComicBookStore.DL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<ComicBook> GetAll()
        {
            return InMemoryDb.BookData;
        }

        public ComicBook GetById(int id)
        {
            return InMemoryDb.BookData
                .First(a => a.Id == id);
        }

        public void Add(ComicBook author)
        {
            InMemoryDb.BookData.Add(author);
        }

        public void Remove(int id)
        {
            var author = GetById(id);
            InMemoryDb.BookData.Remove(author);
        }

        public List<ComicBook> GetAllByAuthor(int authorId)
        {
            return InMemoryDb.BookData
                .Where(b => b.AuthorId == authorId)
                .ToList();
        }
    }
}
