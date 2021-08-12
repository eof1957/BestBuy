using FizzBuzz.Rules;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        List<IRule> rules = new List<IRule>
            {
                // Rules must be kept in this order for running to get proper output
                new Mod3Rule(),
                new Mod5Rule()
            };

        private const string invalidItem = "Invalid Item";
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        private const string FizzBuzz = Fizz + Buzz;

        [Fact]
        public void Give1GetDivided1by3()
        {
            string[] test = {"1"};

            List<List<string>> result = FizzBuzzClass.FizzBuzz(test, rules);
            List<string> returnedList = result[0];
            Assert.Equal(returnedList[0], $"Divided {@test[0]} by 3");
            Assert.Equal(returnedList[1], $"Divided {@test[0]} by 5");
        }

        [Fact]
        public void GiveInvalidGetInvalidItem()
        {
            string[] test = { "A" };
            List<List<string>> result = FizzBuzzClass.FizzBuzz(test, rules);
            List<string> returnedList = result[0];
            Assert.Matches(returnedList[0], invalidItem);
        }

        [Fact]
        public void give3getfizz()
        {
            string[] test = { "3" };

            List<List<string>> result = FizzBuzzClass.FizzBuzz(test, rules);
            List<string> returnedList = result[0];
            Assert.Matches(returnedList[0], Fizz);
        }

        [Fact]
        public void Give5GetBuzz()
        {
            string[] test = { "5" };

            List<List<string>> result = FizzBuzzClass.FizzBuzz(test, rules);
            List<string> returnedList = result[0];
            Assert.Matches(returnedList[0], Buzz);
        }

        [Fact]
        public void Give15GetBuzz()
        {
            string[] test = { "15" };

            List<List<string>> result = FizzBuzzClass.FizzBuzz(test, rules);
            List<string> returnedList = result[0];
            Assert.Matches(returnedList[0], FizzBuzz);
        }

        [Fact]
        public void Give2ItemsGet2Lists()
        {
            string[] test = { "15", "1" };

            List<List<string>> result = FizzBuzzClass.FizzBuzz(test, rules);
            List<string> returnedList = result[0];
            Assert.Matches(returnedList[0], "FizzBuzz");
            returnedList = result[1];
            Assert.Matches(returnedList[0], $"Divided { @test[1]} by 3");
            Assert.Matches(returnedList[1], $"Divided { @test[1]} by 5");
        }

        [Fact]
        public void Give2147483648ItemsGetInvalidItem()
        {
            string[] test = { "2147483648" };

            List<List<string>> result = FizzBuzzClass.FizzBuzz(test, rules);
            List<string> returnedList = result[0];
            Assert.Matches(returnedList[0], invalidItem);
        }

        [Fact]
        public void GiveNoItemGetInvalidItem()
        {
            string[] test = {};

            List<List<string>> result = FizzBuzzClass.FizzBuzz(test, rules);
            List<string> returnedList = result[0];
            Assert.Matches(returnedList[0], invalidItem);
        }

    }
}
