using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility
{
    public class PermMissingElem
    {
        public static int solution2(int[] A)
        {
            if (A.Length == 0) return 1;
            if(A.Length == 1)
            {
                if (A[0] == 1) return 2;
                else return 1;
            }
            Array.Sort(A);
            int diff = A[0];

            if (diff > 1) return 1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] - i != diff)
                    return A[i] - 1;
            }

            return A.Length + 1;
        }

        public static int solution(int[] A)
        {
            int[] rslt = new int[A.Length + 1];

            foreach (int i in A)
                rslt[i - 1] = 1;

            for (int i = 0; i <= A.Length; i++)
            {
                if (rslt[i] == 0)
                    return i + 1;
            }
            return 0;
        }
    }
}
