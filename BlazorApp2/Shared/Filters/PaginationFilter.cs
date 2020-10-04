namespace BlazorApp2.Shared.Filters
{
    public class PaginationFilter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SortBy { get; set; }
        public PaginationFilter()
        {
            this.PageNumber = 1;
            this.PageSize = 10;
            this.SortBy = "ID";
        }
        public PaginationFilter(int pageNumber, int pageSize, string sortBy)
        {
            this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            this.PageSize = pageSize < 10 ? 10 : pageSize;
            this.SortBy = sortBy;
        }
    }
}
