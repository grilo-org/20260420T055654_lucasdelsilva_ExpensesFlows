namespace ExpensesFlows.Exception.ExceptionsBase;
public abstract class ExpensesFlowsException : SystemException
{
    protected ExpensesFlowsException(string message) : base(message)
    {
        
    }

    public abstract int StatusCode { get; }
    public abstract List<string> GetErrors();
}
