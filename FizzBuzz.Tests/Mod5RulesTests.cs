using FizzBuzz.Rules;
using Xunit;

namespace FizzBuzz.Tests
{
    public class Mod5RulesTests
    {
        Mod5Rule mod5rule = new Mod5Rule();
        string SuccessString = "Buzz";

        [Fact]
        public void Give1GetEmpty()
        {
            string result = mod5rule.Run(1);
            Assert.Matches(result, string.Empty);
        }

        [Fact]
        public void Give5GetBuzz()
        {
            string result = mod5rule.Run(5);
            Assert.Matches(result, SuccessString);
        }

        [Fact]
        public void Give10GetBuzz()
        {
            string result = mod5rule.Run(10);
            Assert.Matches(result, SuccessString);
        }
    }
}