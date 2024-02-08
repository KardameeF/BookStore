using ComicBookStore.Models.Models;
using ComicBookStore.Models.Models.Users;

namespace ComicBookStore.Models.Responses
{
    public class GetAllBooksByAuthorResponse
    {
        public Author Author { get; set; }

        public List<ComicBook> Books { get; set; }
    }
}
