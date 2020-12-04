using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codility
{
    public class MaxCounters
    {
        public void Run()
        {
            int N = 5;
            int[] A = new int[] { 3, 4, 4, 6, 1, 4, 4 };

            solution(N, A);
        }

        public int[] solution(int N, int[] A)
        {
            int ogN = N;
            int[] ogA = A;

            int[] counterArray = new int[ogN];

            foreach (int num in ogA)
            {
                if (num > 0 && num <= ogN)
                {
                    counterArray[num - 1]++;
                }
                else if (num > ogN)
                {
                    counterArray = counterArray.Select(x => x = counterArray.Max())
                                               .ToArray();
                }
            }

            return counterArray;
        }
    }
}
