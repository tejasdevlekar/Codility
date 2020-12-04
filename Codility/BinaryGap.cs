using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Codility
{
    public static class BinaryGap
    {
        public static int GetGap(int n)
        {
            string binary = Convert.ToString(n, 2);

            Console.WriteLine(binary);

            string[] binArr = binary.Split('1');

            string maxZeros = string.Empty;

            for (int i = 0; i < binArr.Length-1; i++)
            {
                if (binArr[i].Length > maxZeros.Length)
                {
                    maxZeros = binArr[i];
                }
            }

            return maxZeros.Length;
        }
    }
}
