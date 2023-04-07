using Lab5.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lab5.Models;

namespace Lab5.Data;

public class Lab5Context : IdentityDbContext<Lab5User>
{
    public Lab5Context(DbContextOptions<Lab5Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<Lab5.Models.BankAccount>? BankAccount { get; set; } = default!;
}
