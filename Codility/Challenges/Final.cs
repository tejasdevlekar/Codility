using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.Challenges
{
    public class Final
    {

       
        public void Run()
        {
            int[][] matrix = new int[][]
            {
                new int[]{0, 0, 0, 0},
                new int[]{0, 1, 0, 0},
                new int[]{1, 0, 1, 1}
            };

            //int[][] matrix = new int[][]
            //{
            //    new int[]{0, 1, 0, 1},
            //    new int[]{1, 0, 1, 0},
            //    new int[]{0, 1, 0, 1},
            //    new int[]{1, 0, 1, 0},
            //};
            solution(matrix);

            
        }

        public int solution(int[][] matrix)
        {
            int rowLength = matrix.Length; //3
            int columnLength = matrix.Max(l => l.Length);//4
            List<int> maxRows = new List<int>();

            List<string> combinationList = GetCombinationList(columnLength);

            //check max rows for original matrix
            maxRows.Add(CalculateMaxRows(matrix));

            foreach (var combi in combinationList)
            {
                int[][] matrixTmp = matrix.Select(s => s.ToArray()).ToArray();
                List<string> columns = combi.Split(',').ToList();
                columns.Remove("");

                int[] colNums = columns.ConvertAll(s => int.Parse(s)).ToArray();
                int maxRow = CalculateMaxRows(ComplementMaxtrix(matrixTmp, colNums));
                maxRows.Add(maxRow);
            }

            int result = maxRows.Max();

            return result;
        }

        private List<string> GetCombinationList(int columnLength)
        {
            List<string> combinations = new List<string>();
            List<int> numbers = new List<int>();

            //select 0 is taken care of in solution method
            //start from 1
            for (int i = 0; i < columnLength; i++)
            {
                numbers.Add(i);
            }

            foreach (int num in numbers)
            {
                var result = GetPermutations(numbers, num+1);//change the 2
                foreach (var perm in result)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var c in perm)
                    {
                        //Console.Write(c + " ");
                        sb.Append(c + ",");
                    }
                    //Console.WriteLine();
                    combinations.Add(sb.ToString());
                }
                //Console.ReadKey();
            }


            return combinations;
        }

        public IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items, int count)
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

        

      
        
      
      
        /// <summary>
        /// For multiple columns.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        private int[][] ComplementMaxtrix(int[][] matrix, int[] columns)
        {
            int rowLength = matrix.Length; //3

            for (int currRow = 0; currRow < rowLength; currRow++)
            {
                for (int i = 0; i < columns.Length; i++)
                {
                    matrix[currRow][columns[i]] = matrix[currRow][columns[i]] == 0 ? 1 : 0;
                }
            }

            return matrix;
        }
       
        private int CalculateMaxRows(int[][] matrix)
        {
            int rowLength = matrix.Length; //3
            int columnLength = matrix.Max(l => l.Length);//4
            int rowSum = 0;
            int maxRows = 0;

            for (int currRow = 0; currRow < rowLength; currRow++)
            {
                for (int currColumn = 0; currColumn < columnLength; currColumn++)
                {
                    rowSum += matrix[currRow][currColumn];
                }

                if (rowSum % columnLength == 0) maxRows += 1;
                rowSum = 0;
            }

            return maxRows;
        }

       

    }
}
