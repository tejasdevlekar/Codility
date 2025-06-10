using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility
{
    public class PassingCars
    {
        public void Run()
        {
            int[] A = new int[5] { 0, 1, 0, 1, 1 };
            int result = solution(A);
            Console.WriteLine($"Number of passing cars is {result}");
        }
        public int solution(int[] A)
        {
            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if(A[j] == 1) count++;
                    }
                }
            }

            if (count > 1000000000) count = -1;
            
            return count;
        }
    }
}
