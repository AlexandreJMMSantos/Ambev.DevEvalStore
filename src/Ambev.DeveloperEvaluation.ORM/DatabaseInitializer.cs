using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace Ambev.DeveloperEvaluation.ORM
{
    /// <summary>
    /// Initializes the database with mock data if it's empty.
    /// </summary>
    public class DatabaseInitializer
    {
        private readonly DefaultContext _context;
        private readonly ILogger<DatabaseInitializer> _logger;

        public DatabaseInitializer(DefaultContext context, ILogger<DatabaseInitializer> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Ensures the database is created and seeded with mock data.
        /// </summary>
        public async Task InitializeAsync()
        {
            try
            {
                try
                {
                    _logger.LogInformation("Applying migrations...");
                    await _context.Database.MigrateAsync();
                    _logger.LogInformation("Migrations applied successfully.");
                }
                catch (PostgresException ex) when (ex.SqlState == "42P07") 
                {
                    _logger.LogWarning("Migration skipped: Relation already exists.");
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogWarning(ex, "Migration failed, but continuing execution.");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Unexpected error while applying migrations.");
                }

                if (!await _context.Users.AnyAsync())
                {
                    var defaultUser = new User
                    {
                        Id = Guid.NewGuid(),
                        Username = "admin",
                        Password = "Admin@1234", 
                        Phone = "+5511999999999",
                        Email = "admin@ambev.com",
                        Status = UserStatus.Active,
                        Role = UserRole.Admin,
                        CreatedAt = DateTime.UtcNow
                    };

                    _context.Users.Add(defaultUser);
                    await _context.SaveChangesAsync();
                }

                if (!_context.Products.Any())
                {
                    _logger.LogInformation("No products found. Seeding mock data...");
                    await SeedProductsAsync();
                }
                else
                {
                    _logger.LogInformation("Database already contains products. Skipping seeding.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Database initialization failed: {ex.Message}");
            }
        }

        /// <summary>
        /// Seeds the database with mock products.
        /// </summary>
        private async Task SeedProductsAsync()
        {
            var products = new List<Product>
            {
                new Product { Title = "Smartphone X", Description = "Tela AMOLED 6.5”, câmera dupla", Price = 3999.99M, Category = "Eletrônicos", Image = "smartphone.jpg", Rating = new Rating(4.5M, 200) },
                new Product { Title = "Notebook Gamer", Description = "16GB RAM, RTX 3060, SSD 1TB", Price = 8999.99M, Category = "Computadores", Image = "notebook.jpg", Rating = new Rating(4.8M, 150) },
                new Product { Title = "Fone de Ouvido Bluetooth", Description = "Cancelamento de Ruído Ativo", Price = 799.99M, Category = "Acessórios", Image = "fone.jpg", Rating = new Rating(4.3M, 300) },
                new Product { Title = "Smart TV 50”", Description = "4K UHD, HDR10+, Dolby Atmos", Price = 3299.99M, Category = "Eletrônicos", Image = "tv.jpg", Rating = new Rating(4.6M, 180) },
                new Product { Title = "Console de Videogame", Description = "Suporte a 4K, SSD de 1TB", Price = 4999.99M, Category = "Games", Image = "console.jpg", Rating = new Rating(4.7M, 250) },
                new Product { Title = "Cadeira Gamer", Description = "Ergonômica, Couro sintético, Ajustável", Price = 1199.99M, Category = "Móveis", Image = "cadeira.jpg", Rating = new Rating(4.4M, 120) },
                new Product { Title = "Monitor Ultrawide", Description = "34” IPS, 144Hz, HDR", Price = 2899.99M, Category = "Computadores", Image = "monitor.jpg", Rating = new Rating(4.5M, 90) },
                new Product { Title = "Teclado Mecânico RGB", Description = "Switches Red, Anti-Ghosting", Price = 499.99M, Category = "Acessórios", Image = "teclado.jpg", Rating = new Rating(4.6M, 180) },
                new Product { Title = "Mouse Gamer", Description = "DPI ajustável, Sensor Óptico", Price = 249.99M, Category = "Acessórios", Image = "mouse.jpg", Rating = new Rating(4.5M, 200) },
                new Product { Title = "Smartwatch", Description = "Monitor de Batimentos, GPS Integrado", Price = 1299.99M, Category = "Eletrônicos", Image = "smartwatch.jpg", Rating = new Rating(4.3M, 170) },
                new Product { Title = "Caixa de Som Bluetooth", Description = "À prova d’água, Bateria 12h", Price = 399.99M, Category = "Áudio", Image = "caixa_som.jpg", Rating = new Rating(4.7M, 220) },
                new Product { Title = "Câmera de Segurança Wi-Fi", Description = "Full HD, Visão Noturna", Price = 699.99M, Category = "Segurança", Image = "camera.jpg", Rating = new Rating(4.6M, 110) }
            };

            await _context.Products.AddRangeAsync(products);
            await _context.SaveChangesAsync();
        }
    }
}
