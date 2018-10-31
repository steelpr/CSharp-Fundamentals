using Logger.Models.Contracts;
using System.Globalization;

namespace Logger.Models
{
    public class SimpleLayout : ILayout
    {
        const string DATE_FORMAT = "M/d/yyyy h:mm:ss tt";
        const string FORMAT_ERROR = "{0} - {1} - {2}";

        public string FormatError(IError error)
        {
            string dateFormat = error.DateTime.ToString(DATE_FORMAT, CultureInfo.InvariantCulture);
            string formatError = string.Format(FORMAT_ERROR, dateFormat, error.Level.ToString(), error.Message);
            return formatError;
        }
    }
}