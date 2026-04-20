using System.Net;

namespace ExpensesFlows.Exception.ExceptionsBase;
public class NotFoundException : ExpensesFlowsException
{
    public NotFoundException(string message) : base(message)
    {
    }

    public override int StatusCode => (int)HttpStatusCode.NotFound;

    public override List<string> GetErrors()
    {
        return [Message];
    }
}
