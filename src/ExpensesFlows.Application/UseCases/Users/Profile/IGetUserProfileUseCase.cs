using ExpensesFlows.Communication.Responses;

namespace ExpensesFlows.Application.UseCases.Users.Profile;
public interface IGetUserProfileUseCase
{
    Task<ResponseUserProfileJson> Execute();
}
