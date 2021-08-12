using FizzBuzz.Rules;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz.Tests
{
    public class Mod3RulesTests
    {
        Mod3Rule mod3rule = new Mod3Rule();
        string SuccessString = "Fizz";

        [Fact]
        public void Give1GetEmpty()
        {
            string result = mod3rule.Run(1);
            Assert.Matches(result, string.Empty);
        }

        [Fact]
        public void Give3GetFizz()
        {
            string result = mod3rule.Run(3);
            Assert.Matches(result, SuccessString);
        }

        [Fact]
        public void Give9GetFizz()
        {
            string result = mod3rule.Run(9);
            Assert.Matches(result, SuccessString);
        }

    }
}

