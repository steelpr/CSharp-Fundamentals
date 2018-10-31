using Logger.Models.Contracts;

namespace Logger.Models
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ErrorLevel errorLevel)
        {
            this.Layout = layout;
            this.Level = errorLevel;
        }

        public ILayout Layout { get; }

        public ErrorLevel Level { get; }

        public string Append(IError error)
        {
            string formatError = this.Layout.FormatError(error);
            return formatError;
        }
    }
}
