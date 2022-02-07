using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        public FraudException() //standard constructor
            :base() { }
        public FraudException(string message) //this overloading previous constructor
            : base(message) { }
    }
}
