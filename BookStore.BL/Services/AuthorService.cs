using ComicBookStore.BL.Interfaces;
using ComicBookStore.DL.Interfaces;
using ComicBookStore.Models.Models.Users;

namespace ComicBookStore.BL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public List<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author GetById(int id)
        {
            if (id > 50000) return null;

            return _authorRepository.GetById(id);
        }

        public void Add(Author author)
        {
            _authorRepository.Add(author);
        }

        public void Remove(int id)
        {
            _authorRepository.Remove(id);
        }
    }
}
