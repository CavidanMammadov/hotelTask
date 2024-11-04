using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Helper
{
    internal class NotAvailableException : Exception
    {
        public NotAvailableException(string message):base(message)
        {
            
        }
    }
}
