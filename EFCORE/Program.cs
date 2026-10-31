using EFCORE.Data;
using Microsoft.EntityFrameworkCore;

const string connectionString =
    "Server=(localdb)\\MSSQLLocalDB;Database=ReadMoreBooks;Trusted_Connection=True;TrustServerCertificate=True;";

var options = new DbContextOptionsBuilder<ReadMoreBooksContext>()
    .UseSqlServer(connectionString)
    .Options;

using var context = new ReadMoreBooksContext(options);

var databaseWasCreated = context.Database.EnsureCreated();
var canConnect = context.Database.CanConnect();

Console.WriteLine(databaseWasCreated
    ? "The ReadMoreBooks database was created."
    : "The ReadMoreBooks database already exists.");
Console.WriteLine($"Database connection successful: {canConnect}");
Console.WriteLine("Entity tables:");

foreach (var entityType in context.Model.GetEntityTypes())
{
    Console.WriteLine($"- {entityType.GetTableName()}");
}
