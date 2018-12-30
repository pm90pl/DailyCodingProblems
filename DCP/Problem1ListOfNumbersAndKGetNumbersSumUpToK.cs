using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.

Bonus: Can you do this in one pass?
*/
namespace DCP
{
    public class Problem1ListOfNumbersAndKGetNumbersSumUpToK
    {
        public List<int> Numbers { get; set; }
        public int K { get; set; }

        private void Init()
        {
            var random = new Random();
            if (Numbers == null)
            {
                Numbers = Enumerable.Range(random.Next(), random.Next()).ToList();
            }
            if (K == 0)
            {
                K = random.Next();
            }
        }

        public Problem1ListOfNumbersAndKGetNumbersSumUpToK()
        {
            Init();
        }
        public Problem1ListOfNumbersAndKGetNumbersSumUpToK(int k, List<int> numbers)
        {
            K = k;
            Numbers = numbers;
        }


        public bool Solve()
        {
            for (int i = 0; i < Numbers.Count; i++)
            {
                for (int j = 0; j < Numbers.Count; j++)
                {
                    if (j == i)
                        continue;
                    var sum = Numbers[i] + Numbers[j];
                    if (sum == K)
                        return true;
                }
            }
            return false;
        }


    }
}
