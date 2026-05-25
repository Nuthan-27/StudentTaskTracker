using Microsoft.EntityFrameworkCore;
using StudentTaskTracker.Models;

namespace StudentTaskTracker.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<TaskItem> Tasks => Set<TaskItem>();

    public DbSet<UserModel> Users => Set<UserModel>();
}