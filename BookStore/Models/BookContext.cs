using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace BookStore.Models
{
    public class DbContextFactory
    {
        public static BookContext Create()
        {
            return new BookContext(ConnectionString);
        }

        public static string ConnectionString { get; set; }
    }
    public class BookContext : DbContext
    {
        public BookContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var bookDbInitializer = new BookDbInitializer(modelBuilder);
            Database.SetInitializer(bookDbInitializer);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}