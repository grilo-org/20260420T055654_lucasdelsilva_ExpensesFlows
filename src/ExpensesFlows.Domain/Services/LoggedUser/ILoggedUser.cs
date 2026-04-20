using ExpensesFlows.Domain.Entities;

namespace ExpensesFlows.Domain.Services.LoggedUser;
public interface ILoggedUser
{
    Task<User> Get();
}
