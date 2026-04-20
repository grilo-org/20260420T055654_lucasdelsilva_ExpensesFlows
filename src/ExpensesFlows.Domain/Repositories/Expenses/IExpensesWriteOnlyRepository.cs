using ExpensesFlows.Domain.Entities;

namespace ExpensesFlows.Domain.Repositories.Expenses;
public interface IExpensesWriteOnlyRepository
{
    Task Add(Expense expense);
    Task Delete(long id);
}
