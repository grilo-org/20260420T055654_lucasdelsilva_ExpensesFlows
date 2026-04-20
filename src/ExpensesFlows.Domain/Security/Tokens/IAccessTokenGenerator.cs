using ExpensesFlows.Domain.Entities;

namespace ExpensesFlows.Domain.Security.Tokens;
public interface IAccessTokenGenerator
{
    string Generate(User user);
}
