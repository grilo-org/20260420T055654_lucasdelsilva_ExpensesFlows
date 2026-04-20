using ExpensesFlows.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpensesFlows.Infrastructure.DataAccess;
public class ExpensesFlowsDbContext : DbContext
{
    public ExpensesFlowsDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Expense> Expenses { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Tag>().ToTable("Tags");
    }
}
