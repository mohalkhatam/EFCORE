using EFCORE.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCORE.Data;

public class ReadMoreBooksContext(DbContextOptions<ReadMoreBooksContext> options) : DbContext(options)
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
}
