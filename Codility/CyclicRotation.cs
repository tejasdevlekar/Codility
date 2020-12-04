using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility
{
    public class CyclicRotation
    {
        public static int[] Solution(int[] A, int K)
        {
            if (A.Length == 0) return A;

            if (K % A.Length == 0) return A;

            K = K % A.Length;
            int[] result = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                int newIndex = (i + K) % A.Length;
                result[newIndex] = A[i];
            }

            return result;
        }

        public static int[] RotateArray(int[] array, int nTimes)
        {
            if (array.Length == 0) return array;

            List<int> listArray = array.ToList<int>();
            nTimes %= array.Length;

            if (nTimes == 0) return listArray.ToArray();

            List<int> rotatedArray = new List<int>();
            for (int i = 0; i < nTimes; i++)
            {
                rotatedArray.Clear();
                rotatedArray.Add(listArray.Last());

                listArray.RemoveAt(listArray.Count - 1);
                foreach (int n in listArray)
                {
                    rotatedArray.Add(n);
                }
                listArray = rotatedArray.ToList();
            }

            return rotatedArray.ToArray();
        }
    }
}
