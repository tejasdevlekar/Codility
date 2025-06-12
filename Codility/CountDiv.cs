using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    public class CountDiv
    {
        public void Run()
        {
            Console.WriteLine(solution(6, 11, 2));
        }
       
        public int solution(int A, int B, int K)
        {
            List<int> list = new List<int>();

            for (int i = A; i <= B; i++)
            {
                if (i % K == 0) list.Add(i);
            }


            return list.Count;
        }
    }
}
