using Microsoft.EntityFrameworkCore;
using System;

namespace Demo_SieveLibrary
{
    public class SieveDbContext : DbContext
    {
        public SieveDbContext(DbContextOptions<SieveDbContext> options)
: base(options)
        {
            if (!Initialized)
            {
                SeedData();
                Initialized = true;
            }
        }

        private static bool Initialized = false;
        public DbSet<Product> Products { get; set; }

        private static bool NMultiplyData = false;

        private void SeedData()
        {
            Products.Add(new Product()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Leche Gloria",
                Category = "Leches",
                Cost = 2,
                Description = "Tarro de leche gloria (375 ml)",
                MeasureUnit = "unidad",
                Price = 3.5f,
                Stock = 10,
                Weight = 1
            });

            Products.Add(new Product()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Leche Pura Vida",
                Category = "Leches",
                Cost = 1.5f,
                Description = "Tarro de leche Pura Vida (375 ml)",
                MeasureUnit = "unidad",
                Price = 3.0f,
                Stock = 8,
                Weight = 1
            });

            Products.Add(new Product()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Leche Gloria UHT",
                Category = "Leches",
                Cost = 2.8f,
                Description = "Caja de leche gloria (685 ml)",
                MeasureUnit = "unidad",
                Price = 3.5f,
                Stock = 15,
                Weight = 1
            });

            Products.Add(new Product()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Chocman",
                Category = "Dulces",
                Cost = 0.3f,
                Description = "Barra de chocolate con manjar",
                MeasureUnit = "unidad",
                Price = 0.5f,
                Stock = 26,
                Weight = 1
            });

            Products.Add(new Product()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Doña Pepa",
                Category = "Dulces",
                Cost = 0.5f,
                Description = "Barra de galleta bañada en chocolate",
                MeasureUnit = "unidad",
                Price = 1,
                Stock = 26,
                Weight = 1
            });

            Products.Add(new Product()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Pollo entero",
                Category = "Carnes",
                Cost = 10,
                Description = "Un pollo entero de 3 Kg",
                MeasureUnit = "kg",
                Price = 16,
                Stock = 12,
                Weight = 3
            });

            if (NMultiplyData)
            {
                for (int i = 0; i < 150; i++)
                {
                    Products.Add(new Product()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Leche Gloria",
                        Category = "Leches",
                        Cost = 2,
                        Description = "Tarro de leche gloria (375 ml)",
                        MeasureUnit = "unidad",
                        Price = 3.5f,
                        Stock = 10,
                        Weight = 1
                    });

                    Products.Add(new Product()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Leche Pura Vida",
                        Category = "Leches",
                        Cost = 1.5f,
                        Description = "Tarro de leche Pura Vida (375 ml)",
                        MeasureUnit = "unidad",
                        Price = 3.0f,
                        Stock = 8,
                        Weight = 1
                    });

                    Products.Add(new Product()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Leche Gloria UHT",
                        Category = "Leches",
                        Cost = 2.8f,
                        Description = "Caja de leche gloria (685 ml)",
                        MeasureUnit = "unidad",
                        Price = 3.5f,
                        Stock = 15,
                        Weight = 1
                    });

                    Products.Add(new Product()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Chocman",
                        Category = "Dulces",
                        Cost = 0.3f,
                        Description = "Barra de chocolate con manjar",
                        MeasureUnit = "unidad",
                        Price = 0.5f,
                        Stock = 26,
                        Weight = 1
                    });

                    Products.Add(new Product()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Doña Pepa",
                        Category = "Dulces",
                        Cost = 0.5f,
                        Description = "Barra de galleta bañada en chocolate",
                        MeasureUnit = "unidad",
                        Price = 1,
                        Stock = 26,
                        Weight = 1
                    });

                    Products.Add(new Product()
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Pollo entero",
                        Category = "Carnes",
                        Cost = 10,
                        Description = "Un pollo entero de 3 Kg",
                        MeasureUnit = "kg",
                        Price = 16,
                        Stock = 12,
                        Weight = 3
                    });
                }
            }


            this.SaveChanges();
        }
    }
}
