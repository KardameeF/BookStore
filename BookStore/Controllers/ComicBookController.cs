using ComicBookStore.BL.Interfaces;
using ComicBookStore.Models.Models;
using ComicBookStore.Models.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComicBookController : ControllerBase
    {
        private readonly IComicBookService _bookService;

        public IComicBookService BookService => _bookService;

        public ComicBookController(IComicBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetAll")]
        public List<ComicBook> GetAll()
        {
            return BookService.GetAll();
        }

        [HttpGet("GetById")]
        public ComicBook GetById(int id)
        {
            return BookService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] ComicBook book)
        {
            BookService.Add(book);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            BookService.Remove(id);
        }
    }
}
