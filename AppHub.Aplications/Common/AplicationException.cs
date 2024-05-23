using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppHub.Aplications.Common
{
    public class AplicationException: Exception
    {
        public AplicationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public AplicationException(string? message) : base(message)
        {
        }
    }
}
