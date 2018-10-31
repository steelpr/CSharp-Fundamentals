namespace Logger.Models.Contracts
{
    public interface ILogger
    {
        void Log(IError error);
    }
}
