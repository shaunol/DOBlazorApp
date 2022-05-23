using DOBlazorApp.Server.EntityFramework;
using DOBlazorApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DOBlazorApp.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly BlazorAppContext dbContext;

        public PeopleController(BlazorAppContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IEnumerable<Person>> Get()
        {
            return Array.Empty<Person>();
        }
    }
}