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
            int[] A = { 0, 1, 0, 1, 1 };
            int result = solution(A);
            Console.WriteLine($"Number of passing cars is {result}");
        }

        public int solution(int[] A)
        {
            List<int> list = A.ToList();
            List<int> indexes = findIndexes(list);
            return 0;
        }

        private List<int> findIndexes(List<int> list)
        {
            int occurences = list.Count(x => x == 0);
            List<int> indexes = new List<int>();
            for (int i = 0; i < occurences; i++)
            {
                int index = list.IndexOf(0);
                indexes.Add(index);
                list.RemoveAt(index);
            }

            return null;
        }

        public int solution2(int[] A)
        {
            int result = 0;

            List<int> list = A.ToList();
            var test = list.Count(x => x == 0);
            

            for (int i = 0; i < test; i++)
            {
                int index = list.IndexOf(0);
                list.RemoveAt(index);
               result += calculatePairs(list, index);
                if (result > 1000000000) break;

            }
            return result < 1000000000 ? result : -1;
        }

        public int calculatePairs(List<int> list, int index)
        {
            int count = 0;

            for (int i = index; i < list.Count; i++)
            {
                if (list[i] == 1) count++;
            }
            return count;
        }
        public int solution1(int[] A)
        {
            int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] == 1) count++;
                    }
                }
            }

            if (count > 1000000000) count = -1;

            return count;
        }
    }
}
