using Microsoft.EntityFrameworkCore;

namespace TodoApp3.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
}