using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP
{
    class ProblemSolutionsInvoker
    {
        static void Main(string[] args)
        {
            var problem1 = new Problem1ListOfNumbersAndKGetNumbersSumUpToK(17, new List<int>() {1,294,4,12,455,45456,4 });
            var result = problem1.Solve();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
