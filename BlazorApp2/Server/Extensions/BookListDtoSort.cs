using BlazorApp2.Shared.Entities;
using System.Linq;

namespace BlazorApp2.Server.Extensions
{
    public enum OrderByOptions
    {
        ID = 0,
        ID_Desc,
        Title,
        TItle_Desc,
        Author,
        Author_Desc
    }

    public static class BookListDtoSort
    {
        public static IQueryable<Book> OrderBooksBy(this IQueryable<Book> books, string orderByOptions)
        {
            switch (orderByOptions)
            {
                case "ID":
                    return books.OrderBy(b => b.BookId);

                case "ID_Desc":
                    return books.OrderByDescending(b => b.BookId);

                case "Title":
                    return books.OrderBy(b => b.Title);

                case "Title_Desc":
                    return books.OrderByDescending(b => b.Title);

                case "Author":
                    return books.OrderBy(b => b.Author);

                case "Author_Desc":
                    return books.OrderByDescending(b => b.Author);

                default:
                    return books.OrderBy(b => b.BookId);
            }
        }
    }
}
