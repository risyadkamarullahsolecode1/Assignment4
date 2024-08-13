using Microsoft.EntityFrameworkCore;

namespace Assignment4.Models
{
    public class LibraryContext:DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Peminjaman> Peminjamans { get; set; }
    }
}
