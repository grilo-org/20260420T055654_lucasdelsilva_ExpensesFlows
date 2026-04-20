using ExpensesFlows.Communication.Requests;
using ExpensesFlows.Communication.Responses;

namespace ExpensesFlows.Application.UseCases.Login.DoLogin;
public interface IDoLoginUseCase
{
    Task<ResponseRegisteredUserJson> Execute(RequestLoginJson request);
}
