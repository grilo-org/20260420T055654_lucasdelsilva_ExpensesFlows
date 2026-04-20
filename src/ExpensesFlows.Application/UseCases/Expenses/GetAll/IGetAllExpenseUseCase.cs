using ExpensesFlows.Communication.Responses;

namespace ExpensesFlows.Application.UseCases.Expenses.GetAll;
public interface IGetAllExpenseUseCase
{
    Task<ResponseExpensesJson> Execute();
}
