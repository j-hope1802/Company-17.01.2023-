using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Data;
public class DataContext:DbContext
{
    public DataContext(DbContextOptions<DataContext>options):base(options)
    {

    }
    public DbSet<Book>Books{get;set;}
    public DbSet<Company>Companies{get;set;}
    public DbSet<User>Users{get;set;}
}
