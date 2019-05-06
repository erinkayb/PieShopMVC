using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PieShop.Models
{
    public class AppDbContext : DbContext
    {
        // constructor argument
        // options passed to the base type of options
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Pie> Pies { get; set; }
    }
}
