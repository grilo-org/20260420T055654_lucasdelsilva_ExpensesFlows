using ExpensesFlows.Communication.Responses;

namespace ExpensesFlows.Application.UseCases.Expenses.GetById;
public interface IGetExpenseByIdUseCase
{
    Task<ResponseExpenseJson> Execute(long id);
}
