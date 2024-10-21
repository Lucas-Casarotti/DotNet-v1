using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios01.Entities.Exceptions
{
    public class ContaException : ApplicationException
    {
        public ContaException(string message) : base(message) { }
    }
}
