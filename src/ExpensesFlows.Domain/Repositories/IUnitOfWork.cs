namespace ExpensesFlows.Domain.Repositories;
public interface IUnitOfWork
{
    Task Commit();
}
