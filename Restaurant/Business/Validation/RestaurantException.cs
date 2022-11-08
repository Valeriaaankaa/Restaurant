using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation
{
    public class RestaurantException : Exception
    {
        public RestaurantException()
        {

        }

        public RestaurantException(string message) : base(message)
        {

        }

    }
}
