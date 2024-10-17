using AspNETProj.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNETProj.DatabaseContext;

public class Context: DbContext
{
    public Context(DbContextOptions<Context> options): base(options) { }

    public DbSet<Customer> Customers { get; set; }    
}
