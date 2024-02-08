using ComicBookStore.Models.Models;

namespace ComicBookStore.BL.Interfaces
{
    public interface IComicBookService
    {
        List<ComicBook> GetAll();

        ComicBook GetById(int id);

        void Add(ComicBook book);

        void Remove(int id);

        public List<ComicBook> 
            GetAllByAuthorAfterReleaseDate(
                int authorId,
                DateTime afterDate);
    }
}
