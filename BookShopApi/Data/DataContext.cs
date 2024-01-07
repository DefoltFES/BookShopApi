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
            modelBuilder.Entity<BookOrder>().HasKey(bo => new {bo.IdBook,bo.IdOrder});
            modelBuilder.Entity<BookOrder>().HasOne(b=> b.Book)
                .WithMany(bo=>bo.BookOrders)
                .HasForeignKey(b=>b.IdBook);
            modelBuilder.Entity<BookOrder>().HasOne(b => b.Order)
                .WithMany(bo => bo.BookOrders)
                .HasForeignKey(b => b.IdOrder);

            modelBuilder.Entity<OrderStage>().HasKey(bo => new { bo.IdOrder, bo.IdStage });
            modelBuilder.Entity<OrderStage>().HasOne(o => o.Order)
                .WithMany(os => os.OrderStages)
                .HasForeignKey(b => b.IdOrder);
            modelBuilder.Entity<OrderStage>().HasOne(s => s.Stage)
                .WithMany(os => os.OrderStages)
                .HasForeignKey(b => b.IdStage);

        }
    }
}
