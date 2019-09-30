using System;
using System.Collections.Generic;
using System.Linq;

namespace TopTal
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            int[] testOne = { 1, 3, 6, 4, 1, 2 }; // 5
            int[] testTwo = { 1, 2, 3 }; // 4
            int[] testThree = { -1, -3 }; // 1
            int[] testFour = {2}; // 1
            int[] testFive = { -1, 1, 0, 3 }; // 2
            Random r = new Random();
            var testSix = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
                testSix.Add(r.Next());
            }
            Console.WriteLine(s.solution(testFour));
        }
    }
    // you can also use other imports, for example:
    // using System.Collections.Generic;

    // you can write to stdout for debugging purposes, e.g.
    // Console.WriteLine("this is a debug message");

    class Solution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int intResult = 1;
            var lstInput = A.ToList();
            var intMin = lstInput.Min();
            var intMax = lstInput.Max();
            if (intMin < 0 && intMax < 0)
            {
                return intResult;
            }

            if (intMin < 0)
            {
                lstInput = lstInput.Where(s => s > 0).ToList();
            }

            var lstCount = lstInput.Count;
            lstInput.Sort();
            for (int i = 0; i < lstCount; i++)
            {
                if (i == lstCount - 1)
                {
                    intResult = lstInput[i] + 1;
                    return intResult;
                }

                var intCandidate = lstInput[i] + 1;
                if (i == lstCount || i < lstCount && intCandidate < lstInput[i + 1])
                {
                    intResult = intCandidate;
                    if (!lstInput.Contains(intResult))
                    {
                        return intResult;
                    }
                }
            }
            return intResult;
        }
    }

}
