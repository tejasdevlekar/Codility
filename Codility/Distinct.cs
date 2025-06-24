using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class Distinct
    {
        public void Run()
        {
            //int[] array = { 2, 1, 1, 2, 3, 1 };
            //int[] array = { 2 };
            int[] array = { 0, 1, 2 };
            //int[] array = { -2, -1, -1, 0, 1, 1, 2, 3 };
            solution(array);
        }

        public int solution(int[] A)
        {
            switch (A.Length)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
            }
            List<int> sortedArray = A.ToList();
            sortedArray.Sort();
            int count = 0;
            int num = -2147483648;

            for (int i = 0; i < A.Length; i++)
            {
                if (num == sortedArray[i]) continue;
                num = sortedArray[i];
                count++;
            }
            return count;
        }

        public int solution1(int[] A)
        {
            if (A.Length == 0) return 0;

            int[] result = new int[A.Max() + 1];
            int sum = 0;
            //int[] sortedArray = Sort(A);
            for (int i = 0; i < A.Length; i++)
            {
                if (result[A[i]] > 0) continue;
                result[A[i]] += 1;
                sum++;
            }
            return sum;
        }

        private int[] Sort(int[] a)
        {
            int[] result = new int[a.Length];
            int sum = 0;
            int[] sortedArray = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                result[a[i]] += 1;
                sum += a[i];
            }

            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (result[i] == 0) continue;
                for (int j = 0; j < result[i]; j++)
                {
                    sortedArray[k] = i;
                    k++;
                }
            }
            return sortedArray;
        }
    }
}
