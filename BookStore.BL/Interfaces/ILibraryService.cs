using ComicBookStore.Models.Requests;
using ComicBookStore.Models.Responses;

namespace ComicBookStore.BL.Interfaces
{
    public interface ILibraryService
    {
        GetAllBooksByAuthorResponse?
            GetAllBooksByAuthorAfterReleaseDate(
                GetAllBooksByAuthorRequest request);

        int CheckBookCount(int input);
    }
}
