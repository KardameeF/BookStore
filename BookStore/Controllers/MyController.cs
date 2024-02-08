using ComicBookStore.BL.Interfaces;
using ComicBookStore.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Book2Controller : ControllerBase
    {
        private readonly IComicBookService _bookService;

        public Book2Controller(IComicBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetBookById")]
        public ComicBook GetBookById(int id)
        {
            return _bookService.GetById(id);
        }

        [HttpGet("GetAllBooks")]
        public List<ComicBook> GetAllBooks()
        {
            return _bookService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody]ComicBook book)
        {
            _bookService.Add(book);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _bookService.Remove(id);
        }

    }
}
