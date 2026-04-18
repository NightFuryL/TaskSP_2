using LibraryTask.Data;
using Microsoft.EntityFrameworkCore;
namespace WinFormsTask;
public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
    public const string path = @"Data Source=NIGHTFURY\LEVMSSQLSERVER;Initial Catalog=UsersDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(path);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasKey(u => u.Id);
    }
}