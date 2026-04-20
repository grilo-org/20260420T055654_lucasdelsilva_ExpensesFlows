namespace ExpensesFlows.Domain.Security.Tokens;
public interface ITokenProvider
{
    string TokenOnRequest();
}
