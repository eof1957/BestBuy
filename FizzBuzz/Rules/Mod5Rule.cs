using System;

namespace FizzBuzz.Rules
{
    public class Mod5Rule : IRule
    {
        public string Run(Int32 number)
        {
            return (number % 5) == 0 ? "Buzz" : string.Empty;
        }
    }
}
