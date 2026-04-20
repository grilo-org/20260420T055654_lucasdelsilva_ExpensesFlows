using ExpensesFlows.Communication.Requests;

namespace ExpensesFlows.Application.UseCases.Users.ChangePassword;
public interface IChangePasswordUseCase
{
    Task Execute(RequestChangePasswordJson request);
}
