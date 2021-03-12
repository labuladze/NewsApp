using Microsoft.EntityFrameworkCore;
using NewsApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsApi.Data
{
    public class NewsDbContext : DbContext
    {
        public NewsDbContext(DbContextOptions<NewsDbContext> opt) : base(opt)
        {

        }

        public DbSet<News> NewsSet { get; set; }
    }
}
