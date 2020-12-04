using System.Collections.Generic;
using System.Linq;

namespace Codility
{
    public static class OddOccurrencesInArray
    {

        public static int Solution2(int[] A)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            foreach (var num in A)
            {
                if (numbers.ContainsKey(num))
                {
                    numbers[num] += 1;
                }
                else
                {
                    numbers[num] = 1;
                }
            }

            foreach (var key in numbers.Keys)
            {
                if(numbers[key] % 2 == 1)
                {
                    return key;
                }
            }

            return 0;
        }
        public static int Solution(int[] A)
        {
            if (A.Length == 0) return 0;
            else if (A.Length % 2 == 0) return 0;

            List<int> oddArray = A.ToList();

            int unpairedNumber = oddArray.GroupBy(x => x)
                    .Where(g => g.Count() % 2 == 1)
                    .Select(x => x.Key).SingleOrDefault();

            return unpairedNumber;
        }
    }
}
