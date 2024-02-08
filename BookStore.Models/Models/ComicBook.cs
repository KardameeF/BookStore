
namespace ComicBookStore.Models.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public string Artist { get; set; }

        public ComicBook(string artist) => Artist = artist;

        public ComicBook()
        {
        }

        public DateTime ReleaseDate { get; set; }
    }

}
