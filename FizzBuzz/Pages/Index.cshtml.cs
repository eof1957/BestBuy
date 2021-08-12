using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;


using FizzBuzz;

using System.IO;
using FizzBuzz.Rules;

namespace FizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        private IHostingEnvironment _environment;
        public IndexModel(IHostingEnvironment env)
        {
            _environment = env;
        }
        [BindProperty]
        public string[] testValues { get; set; }

        [BindProperty]
        public List<List<string>> fizzbuzzresults { get; set; }

        [BindProperty]
        private IFormFile testData { get; set; }

        public void OnGet()
        {
            var rules = new List<IRule>
            {
                // Rules must be kept in this order for running to get proper output
                new Mod3Rule(),
                new Mod5Rule()
            };
            var contentRoot = _environment.ContentRootPath;
            var file = Path.Combine(contentRoot,"App_Data/FizzBuzzTestData.txt");
            if (System.IO.File.Exists(file))
            {
                string[] userData = null;
                userData = System.IO.File.ReadAllLines(file);

                testValues = userData[0].Split(' ');
                fizzbuzzresults = FizzBuzzClass.FizzBuzz(testValues, rules);
            }
        }
    }
}
