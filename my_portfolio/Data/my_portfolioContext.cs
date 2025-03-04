using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using my_portfolio.Models;

namespace my_portfolio.Data
{
    public class my_portfolioContext : DbContext
    {
        public my_portfolioContext (DbContextOptions<my_portfolioContext> options)
            : base(options)
        {
        }

        public DbSet<my_portfolio.Models.Messages> Messages { get; set; } = default!;
    }
}
