using DOBlazorApp.Server.EntityFramework;
using DOBlazorApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DOBlazorApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : ControllerBase
    {
        private readonly BlazorAppContext dbContext;

        public CompaniesController(BlazorAppContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Company>> Get()
        {
            return await dbContext.Companies.ToListAsync();
        }
    }
}