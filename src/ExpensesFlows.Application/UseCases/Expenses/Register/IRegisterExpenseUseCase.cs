using ExpensesFlows.Communication.Requests;
using ExpensesFlows.Communication.Responses;

namespace ExpensesFlows.Application.UseCases.Expenses.Register;
public interface IRegisterExpenseUseCase
{
    Task<ResponseRegisteredExpenseJson> Execute(RequestExpenseJson request);
}
