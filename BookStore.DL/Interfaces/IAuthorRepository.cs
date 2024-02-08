using ComicBookStore.Models.Models.Users;

namespace ComicBookStore.DL.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();

        Author GetById(int id);

        void Add(Author author);

        void Remove(int  id);
    }
}
