using ComicBookStore.BL.Interfaces;
using ComicBookStore.DL.Interfaces;
using ComicBookStore.Models.Models;

namespace ComicBookStore.BL.Services
{
    public class ComicBookService : IComicBookService
    {
        private readonly IBookRepository _bookRepository;
        
        public ComicBookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public List<ComicBook> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public ComicBook GetById(int id)
        {
            if (id <= 0) return new ComicBook();

            return _bookRepository.GetById(id);
        }

        public void Add(ComicBook book)
        {
            _bookRepository.Add(book);
        }

        public void Remove(int id)
        {
           _bookRepository.Remove(id);
        }

        public List<ComicBook> GetAllByAuthorAfterReleaseDate
            (int authorId, DateTime afterDate)
        {
            var result =
                _bookRepository.GetAllByAuthor(authorId);

            return result
                .Where(b => b.ReleaseDate >= afterDate)
                .ToList();
        }
    }
}
