using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9._6
{
    internal class NewException : Exception
    {
        public NewException(string message) : base(message) { }
    }
}
