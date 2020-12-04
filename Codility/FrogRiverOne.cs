using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Codility
{
    public static class FrogRiverOne
    {

        public static void Run()
        {
            int[] A = { 1, 3, 1, 4, 3, 5, 4 };
            int X = 5;
            int test = solution3(X, A);

            Console.WriteLine($"Seconds are {test}");
        }

        //working score 100%
        //Complexity O(N)
        public static int solution3(int X, int[] A)
        {
            int[] positions = new int[X + 1];
            int seconds = 0;
            int count = 0;

            foreach (int leafPositions in A)
            {
                seconds++;
                if (positions[leafPositions] == 0)
                {
                    positions[leafPositions]++;
                    count++;
                }

                if (count == X)
                {
                    return seconds - 1;
                }

                //return seconds
            }
            return -1;
        }

        //working correctness 100% score 54%
        //Complexity O(N**2)
        public static int solution2(int X, int[] A)
        {
            int[] positions = new int[X + 1];
            int seconds = 0;

            foreach (int leafPositions in A)
            {
                seconds++;
                if (positions[leafPositions] == 0)
                {
                    positions[leafPositions] += 1;
                }

                if (positions.Sum() == X)
                {
                    return seconds - 1;
                }

                //return seconds
            }
            return -1;
        }

        public static int solution(int X, int[] A)
        {
            int[] positions = new int[X + 1];
            int seconds = 0;
            int sumLengthA = Sum(A.Length - 1);
            int sumA = A.Sum();
            int difference = Math.Abs(sumLengthA - sumA);

            foreach (int leafPositions in A)
            {
                seconds++;
                positions[leafPositions] += 1;
                if (positions.Sum() == difference + 1)
                {
                    return seconds - 1;
                }
                //return seconds
            }
            return -1;
        }

        public static int Sum(int count)
        {
            int total = 0;
            for (int i = 1; i <= count; i++)
            {
                total += i;
            }
            return total;
        }

        //public int SumArray()
    }
}
