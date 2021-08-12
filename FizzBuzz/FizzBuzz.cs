using FizzBuzz.Rules;
using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    static public class FizzBuzzClass
    {
        static public List<List<string>> FizzBuzz(IEnumerable<string> list, List<IRule> rulesList)
        {
            const string InvalidItem = "Invalid Item";

            List<List<string>> returnList = new List<List<string>>();
            List<string> individualItemList = new List<string>();
            Int32 parsedNumber;

            // Run FizzBuzz for each value in input list
            foreach (var item in list)
            {
                individualItemList = new List<string>();

                // Note TryParse will update parsedNumber if it is a valid Int32 number
                if (Int32.TryParse(item, out parsedNumber))
                {
                    var output = string.Empty;

                    foreach (var rule in rulesList)
                    {
                        output += rule.Run(parsedNumber);
                    }

                    if (output == string.Empty)
                    {
                        individualItemList.Add($"Divided {parsedNumber} by 3");
                        individualItemList.Add($"Divided {parsedNumber} by 5");
                        returnList.Add(individualItemList);
                    }
                    else
                    {
                        individualItemList.Add(output);
                        returnList.Add(individualItemList);
                    }
                 }
                else
                {
                    individualItemList.Add(InvalidItem);
                    returnList.Add(individualItemList);
                }
            }
            if (returnList.Count == 0)
            {
                individualItemList.Add(InvalidItem);
                returnList.Add(individualItemList);
            }
            return returnList;
        }
    }
}
