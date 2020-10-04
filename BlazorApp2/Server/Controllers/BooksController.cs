using System.Linq;
using System.Threading.Tasks;
using BlazorApp2.Server.Data;
using BlazorApp2.Shared.Filters;
using BlazorApp2.Shared.Wrappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly AppDbContext context;

        public BooksController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> List([FromQuery]PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);

            var books = await context.Books
                .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                .Take(validFilter.PageSize)
                .ToListAsync();

            var totalRecords = await context.Books.CountAsync();

            var pagedBooks = new PagedBooks { Books = books, PageNumber = validFilter.PageNumber, PageSize = validFilter.PageSize, TotalRecords = totalRecords };

            return Ok(pagedBooks);
        }
    }
}
