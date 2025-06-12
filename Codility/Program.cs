using Codility.Challenges;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinaryGapRun();

            //Console.WriteLine(FrogJump.solution3(5, 1000000000, 2));
            //Console.WriteLine(FrogJump.solution3(10, 85, 30));
            //Console.WriteLine(FrogJump.solution(1, 5, 2));
            //Console.WriteLine(FrogJump.solution(5, 105, 3));

            //TapeEquilibrium.Run();
            //FrogRiverOne.Run();
            //Niobium2019FlippingMatrix.Run();
            //new Final().Run();
            //new MaxCounters().Run();
            //new PassingCars().Run();
            //new CountDiv().Run();
            new YearOfTheRabbit().Run();




            //var list = new List<string> { "0", "1", "2", "3" };
            //var result = GetPermutations(list, 2);
            //foreach (var perm in result)
            //{
            //    foreach (var c in perm)
            //    {
            //        Console.Write(c + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
        }

        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items, int count)
        {
            int i = 0;
            foreach (var item in items)
            {
                if (count == 1)
                    yield return new T[] { item };
                else
                {
                    foreach (var result in GetPermutations(items.Skip(i + 1), count - 1))
                        yield return new T[] { item }.Concat(result);
                }

                ++i;
            }
        }

       

        /*WORKING sort of*/
        //private static int GetCombinations(int[] numbers, int digitLength, int combinationLength)
        //{
        //    //int[,] combinations = new int[combinationLength, digitLength];
        //    //List<List<int>> combinations = new List<List<int>>();
        //    //Dictionary<int, int> combinations = new Dictionary<int, int>();
        //    List<List<int>> combinations = new List<List<int>>();


        //    for (int i = 0; i < combinationLength; i++)
        //    {
        //        for (int j = 0; j < numbers.Length; j++)
        //        {
        //            if (i == j) continue;
        //            if (j < i) continue;
        //            combinations.Add(new List<int>() { i, j });
        //        }

        //    }
        //    return 0;
        //}

        //private static int GetCombinations(int[] numbers, int digitLength, int combinationLength)
        //{
        //    List<string> combinations = new List<string>();

        //    for (int i = 0; i < combinationLength; i++)
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        for (int j = 0; j < numbers.Length; j++)
        //        {
        //            if (j <= i) continue;
        //            sb.Append(numbers[j] + ",");
        //        }
        //        combinations.Add(sb.ToString());

        //        if (combinations.Count == combinationLength) break;
        //    }

        //    return 0;
        //}
        private static void BinaryGapRun()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int binaryGap = BinaryGap.GetGap(number);

            Console.WriteLine($"Binary gap is {binaryGap}");
        }
    }
}
