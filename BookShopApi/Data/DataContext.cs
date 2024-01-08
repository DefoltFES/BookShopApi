using BookShopApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BookShopApi.Data
{
    public class DataContext: DbContext
    {
         public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User > Users { get; set; }
        public DbSet<OrderStage> OrderStages { get; set; }
        public DbSet<BookOrder> BookOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }
    }
}
