using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Entities.Exceptions
{
    public class DomainExpection : ApplicationException
    {
        public DomainExpection(string message) : base(message){ }
    }
}
