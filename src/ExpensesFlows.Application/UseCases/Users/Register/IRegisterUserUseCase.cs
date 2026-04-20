using ExpensesFlows.Communication.Requests;
using ExpensesFlows.Communication.Responses;

namespace ExpensesFlows.Application.UseCases.Users.Register;
public interface IRegisterUserUseCase
{
    Task<ResponseRegisteredUserJson> Execute(RequestRegisterUserJson request);
}
