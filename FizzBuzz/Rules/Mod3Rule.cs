using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Rules
{
    public class Mod3Rule : IRule
    {
        public string Run(Int32 number)
        {
            return (number % 3) == 0 ? "Fizz" : string.Empty;
        }
    }
}
