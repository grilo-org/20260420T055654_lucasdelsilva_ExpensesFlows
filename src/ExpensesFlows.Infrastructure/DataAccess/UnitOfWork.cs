using ExpensesFlows.Domain.Repositories;

namespace ExpensesFlows.Infrastructure.DataAccess;
internal class UnitOfWork : IUnitOfWork
{
    private readonly ExpensesFlowsDbContext _dbContext;
    public UnitOfWork(ExpensesFlowsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Commit() => await _dbContext.SaveChangesAsync();
}
