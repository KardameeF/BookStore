﻿using ComicBookStore.Models.Models;
using ComicBookStore.Models.Models.Users;

namespace ComicBookStore.DL.MemoryDb
{
    public static class InMemoryDb
    {
        public static List<Author> AuthorsData
            = new List<Author>()
            {
                new Author()
                {
                    Id = 1,
                    Name = "Name 1",
                    BirthDay = DateTime.Now
                },
                new Author()
                {
                    Id = 2,
                    Name = "Name 2",
                    BirthDay = DateTime.Now
                },
                new Author()
                {
                    Id = 3,
                    Name = "Name 3",
                    BirthDay = DateTime.Now
                },
            };

        public static List<ComicBook> BookData
            = new List<ComicBook>()
            {
                new ComicBook()
                {
                    Id = 1,
                  Title = "Book 1",
                  AuthorId = 1,
                  ReleaseDate = new DateTime(2005,05,07)
                },
                new ComicBook()
                {
                    Id = 4,
                    Title = "Book 4",
                    AuthorId = 1,
                    ReleaseDate = new DateTime(2007,05,07)
                },
                new ComicBook()
                {
                    Id = 2,
                    Title = "Book 2",
                    AuthorId = 2,
                    ReleaseDate = new DateTime(2015,05,07)
                },
                new ComicBook()
                {
                    Id = 3,
                  Title = "Book 3",
                  AuthorId = 3,
                  ReleaseDate = new DateTime(2010,05,07)
                },
            };
    }
}
