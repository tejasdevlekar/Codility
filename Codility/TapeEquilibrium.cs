using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility
{
    public static class TapeEquilibrium
    {
        public static void Run()
        {
            int[] A = { 3, 1, 2, 4, 3 };
            Console.WriteLine($"Result is {solution3(A)}");
        }

        public static int solution3(int[] A)
        {
            int[] sums = new int[A.Length];
            int[] reverseSums = new int[A.Length];

            sums[0] = A[0];
            reverseSums[A.Length - 1] = A[A.Length - 1];
            for(int i = 1; i < A.Length; i++)
            {
                sums[i] = sums[i-1] + A[i];
                reverseSums[A.Length - 1 - i] = reverseSums[A.Length - i] + A[A.Length - 1 - i];  
            }

            int diff = int.MaxValue;
            for (int i = 0; i < A.Length-1; i++)
            {
                int tDiff = Math.Abs(sums[i] - reverseSums[i+1]);
                diff = Math.Min(diff, tDiff);
            }

            return diff;
        }

        public static int solution2(int[] A)
        {
            List<int> firstPart = new List<int>(A.Take(1));
            List<int> secondPart = new List<int>(A.Skip(1));
            List<int> total = new List<int>();

            //int firstPartTotal = ;
            //int secondPartTotal = 

            for (int i = 1; i < A.Length; i++)
            {
                total.Add(Math.Abs(firstPart.Sum() - secondPart.Sum()));

                firstPart.Add(secondPart[0]);
                secondPart.RemoveAt(0);
            }

            int minVal = total.Min();

            return minVal;
        }

        public static int solution(int[] A)
        {
            int index = 1;
            List<int> splitResult = new List<int>();

            while(index < A.Length)
            {
                splitResult.Add(Split(index, A));
                index++;
            }
            return splitResult.Min();
        }

        private static int Split(int index, int[] A)
        {
            int firstPart = 0;
            int secondPart = 0;

            for (int i = 0; i < index; i++)
            {
                firstPart += A[i];
            }

            for (int i = index; i < A.Length; i++)
            {
                secondPart += A[i];
            }

            return Math.Abs(firstPart - secondPart);
        }
    }
}
