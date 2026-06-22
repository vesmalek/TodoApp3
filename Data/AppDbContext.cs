using Microsoft.EntityFrameworkCore;
using TodoApp3.Models;

namespace TodoApp3.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<TodoItem> TodoItems { get; set; }
}