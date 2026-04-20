using ExpensesFlows.Communication.Requests;

namespace ExpensesFlows.Application.UseCases.Users.Update;
public interface IUpdateUserUseCase
{
    Task Execute(RequestUpdateUserJson request);
}
