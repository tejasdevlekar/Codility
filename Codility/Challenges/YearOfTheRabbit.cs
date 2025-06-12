using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Challenges
{
    public class YearOfTheRabbit
    {
        public int Count = 0;
        public void Run()
        {
            //int[] A = { 1, 3, 5, 2, 8, 7 };
            //int[] B = { 7, 1, 9, 8, 5, 7 };
            //[5, 7, 7, 1, 9, 8]

            //int[] A = { 1, 1, 1, 1 };
            //int[] B = { 1, 2, 3, 4 };

            int[] A = { 3, 1, 4, 2 };
            int[] B = { 1, 4, 3, 2 };
            Console.WriteLine(solution(A, B));
        }

        private int solution(int[] A, int[] B)
        {
            //if (Count > A.Length) return -1;
            return CompareDishes(A, B);
        }

        public int CompareDishes(int[] A, int[] B)
        {
            if (Count > A.Length) return -1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == B[i])
                {
                    int[] rotatedArray = RotateTable(A, B);
                    int result = CompareDishes(A, rotatedArray);
                    if (result == -1)
                    {
                        Count = -1;
                        break;
                    }
                    break;
                }
            }

            return Count;
        }

        private int[] RotateTable(int[] a, int[] b)
        {
            Count++;
            int[] rotatedArray = new int[b.Length];
            rotatedArray[0] = b[b.Length - 1];

            for (int i = 1; i < b.Length; i++)
            {
                rotatedArray[i] = b[i-1];
            }

            return rotatedArray;
        }
    }
}
