using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Rules
{
    public interface IRule
    {
        string Run(Int32 value);
    }
}
