using BlazorCRUDChartSignalR.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDChartSignalR.Server.Data
{
    public class DataGenerator
    {
        public static void SeedData(ProductDbContext context)
        {
            var product1 = new Product
            {
                ProdName = "Luke",
                ProdStockAmount = 10
            };

            context.products.Add(product1);

            var product12 = new Product
            {
                ProdName = "Nama",
                ProdStockAmount = 10
            };

            context.products.Add(product12);

            context.SaveChanges();
        }
    }
}
