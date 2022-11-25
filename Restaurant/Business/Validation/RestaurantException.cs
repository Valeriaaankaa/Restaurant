using System.Globalization;

namespace Business.Validation
{
    public class RestaurantException : Exception
    {
        public RestaurantException() : base() { }        

        public RestaurantException(string message) : base(message)  {}

        public RestaurantException(string message, params object[] args ) : base(String.Format(CultureInfo.CurrentCulture,message, args)) { }

    }
}
