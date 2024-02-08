using ComicBookStore.Models.Models;
using ComicBookStore.Models.Models.Users;

namespace ComicBookStore.DL.Interfaces
{
    public interface IBookRepository
    {
        List<ComicBook> GetAll();

        ComicBook GetById(int id);

        void Add(ComicBook book);

        void Remove(int  id);

        List<ComicBook> GetAllByAuthor(int authorId);
    }
}
