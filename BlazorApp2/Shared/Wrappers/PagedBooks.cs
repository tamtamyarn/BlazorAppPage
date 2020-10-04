using BlazorApp2.Shared.Entities;
using System.Collections.Generic;

namespace BlazorApp2.Shared.Wrappers
{
    public class PagedBooks
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }

        public List<Book> Books { get; set; }
    }
}
