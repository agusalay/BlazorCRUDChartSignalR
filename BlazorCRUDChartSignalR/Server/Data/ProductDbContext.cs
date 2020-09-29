using BlazorCRUDChartSignalR.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDChartSignalR.Server.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> option) : base(option)
        { 
        
        }

        public DbSet<Product> products { get; set; }
    }
}
