using ComicBookStore.BL.Interfaces;
using ComicBookStore.Models.Requests;
using ComicBookStore.Models.Responses;
using ComicBookStore.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;

        public LibraryController(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpPost("GetAllBooksByAuthorAndDate")]
        public GetAllBooksByAuthorResponse?
            GetAllBooksByAuthorAndDate([FromBody]
                GetAllBooksByAuthorRequest request)
        {
            return _libraryService
                .GetAllBooksByAuthorAfterReleaseDate(request);
        }

        [HttpPost("SomeEndpoint")]
        public string GetSomeData([FromBody] SomeRequest request)
        {
           return "Ok";
        }
    }
}
