using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace Codility
{
    public class MaxCounters
    {
        public void Run()
        {
            int N = 5;
            int[] A = new int[] { 3, 4, 4, 6, 1, 4, 4 };

            int[] result = solution2(N, A);
            result.ToList().ForEach(r => Console.Write($"{r} "));
            Console.WriteLine();

            A = new int[] { 3, 4, 4, 6, 1, 4, 6 };

            result = solution2(N, A);
            result.ToList().ForEach(r => Console.Write($"{r} "));
            Console.WriteLine();

            A = new int[] { 6, 6, 6, 6, 6, 6, 6 };

            result = solution2(N, A);
            result.ToList().ForEach(r => Console.Write($"{r} "));
            Console.WriteLine();

            A = new int[] { 6,6,6,6,6,6,6,3, 4, 4, 6, 1, 4, 6,6,6,6,6,6,6,6 };

            result = solution2(N, A);
            result.ToList().ForEach(r => Console.Write($"{r} "));
            Console.WriteLine();

            A = new int[] { 6, 6, 6, 6, 6, 6, 6, 3, 4, 4, 6, 1, 4, 4, 6, 6, 6, 6, 6, 6, 6 };

            result = solution2(N, A);
            result.ToList().ForEach(r => Console.Write($"{r} "));
            Console.WriteLine();

            A = new int[] { 6, 6, 6, 6, 6, 6, 6, 3, 4, 4, 6,6,6,6,6,6,6,6,6, 1, 4, 6, 6, 6, 6, 6, 6, 6, 6 };

            result = solution2(N, A);
            result.ToList().ForEach(r => Console.Write($"{r} "));
            Console.WriteLine();

            A = new int[] { 6, 6, 6, 6, 6, 6, 6, 3, 4, 4, 6,6,6,6,6,6,6,6,6,6, 1, 4, 4, 6, 6, 6, 6, 6, 6, 6 };

            result = solution2(N, A);
            result.ToList().ForEach(r => Console.Write($"{r} "));
            Console.WriteLine();
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

        public int[] solution2(int N, int[] A)
        {
            int[] array = A;
            int[] count = new int[N];
            int[] tmpcount = new int[N];
            int maxVal = 0;
            int tmpMaxVal = 0;
            foreach (int num in array)
            {
                if (num > N)
                {
                    if (tmpMaxVal > 0)
                    {
                        maxVal += tmpMaxVal;
                        count = new int[N];
                        tmpMaxVal = 0;
                    }
                }
                else
                {
                    count[num-1]++;
                    tmpMaxVal = Math.Max(tmpMaxVal, count[num - 1]);
                }
            }

            if (maxVal > 0)
            {
                for (int i = 0; i < count.Length; i++)
                {
                    count[i] += maxVal;
                }
            }

            return count;
        }


    }
}
