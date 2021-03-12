using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApi.Controllers
{   
    [Route("api/news")]
    [ApiController]
    [Produces("application/json")]
    public class NewsController : Controller
    {
        private readonly NewsDbContext _ctx;

        public NewsController(NewsDbContext ctx)
        {
            _ctx = ctx;
        }

        // Get: api/news
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var res = await _ctx.NewsSet.ToListAsync();
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }

        // Get: api/news/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAll(int id)
        {
            var res = await _ctx.NewsSet.FirstOrDefaultAsync(x => x.Id == id);
            if (res == null)
            {
                return NotFound();
            }
            return Ok(res);
        }
    }
}
