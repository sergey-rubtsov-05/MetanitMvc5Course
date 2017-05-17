using System.Data.Entity;
using System.Data.SQLite;

namespace BookStore.Models
{
    public class DbContextFactory
    {
        public static BookContext Create()
        {
            return new BookContext(DbFileName);
        }

        public static string DbFileName { get; set; }
    }

    public class BookContext : DbContext
    {
        public BookContext(string dbFileName) : base(
            new SQLiteConnection(new SQLiteConnectionStringBuilder { DataSource = dbFileName, Version = 3 }
                .ConnectionString), true)
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