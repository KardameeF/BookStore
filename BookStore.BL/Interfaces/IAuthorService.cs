using ComicBookStore.Models.Models.Users;

namespace ComicBookStore.BL.Interfaces
{
    public interface IAuthorService
    {
        List<Author> GetAll();

        Author GetById(int id);

        void Add(Author author);

        void Remove(int id);
    }
}
