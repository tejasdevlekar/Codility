using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.Challenges
{
    public static class Niobium2019FlippingMatrix
    {

        //int rowLength = matrix.GetLength(0); //3
        //int columnLength = matrix.GetLength(1); //4

        //    for (int currRow = 0; currRow<rowLength; currRow++)
        //    {
        //        for (int currColumn = 0; currColumn<columnLength; currColumn++)
        //        {
        //        }
        //    }

        public static void Run()
        {
            int[,] matrix =  {
                {0, 0, 0, 0},
                {0, 1, 0, 0},
                {1, 0, 1, 1}
            };
            solution(matrix);

            //Console.WriteLine("Matrix compliment column 3");
            //PrintMatrix(ComplimentMaxtrix(matrix, 3));
            //Console.WriteLine();
            //Console.WriteLine($"Max rows = {CalculateMaxRows(matrix)}");


            //int[,] newMatrix = ComplementMaxtrix(matrix, 0, 1);
            //int[,] newMatrix = ComplementMaxtrix(matrix, new int[] { 0, 3 });
            //PrintMatrix(newMatrix);
            //int maxRows = CalculateMaxRows(newMatrix);
            //Console.WriteLine(maxRows);

            //PrintMatrix(matrix);
        }

        public static int solution(int[,] A)
        {
            int[,] matrix = A;
            int rowLength = matrix.GetLength(0); //3
            int columnLength = matrix.GetLength(1); //4
            List<int> maxRows = new List<int>();

            List<string> combinationList = GetCombinationList(columnLength);

            foreach (var combi in combinationList)
            {
                List<string> columns = combi.Split(',').ToList();
                columns.Remove("");

                int[] colNums = columns.ConvertAll(s => int.Parse(s)).ToArray();
                int maxRow = CalculateMaxRows(ComplementMaxtrix(matrix, colNums));
                maxRows.Add(maxRow);
            }

            int result = maxRows.Sum();

            return result;
        }

        private static List<string> GetCombinationList(int columnLength)
        {
            List<string> combinations = new List<string>();
            List<string> numbers = new List<string>();

            for (int i = 0; i < columnLength; i++)
            {
                numbers.Add(i.ToString());
            }

            
            var result = GetPermutations(numbers, 2);
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

            return combinations;
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

        //private static int[] FlipColumns(int columnLength)
        //{
        //    //initialize column numbers
        //    int[] columnNumbers = new int[columnLength];
        //    for (int i = 0; i < columnNumbers.Length; i++)
        //    {
        //        columnNumbers[i] = i;
        //    }

        //    //calculate total combinations. Must be 16
        //    int totalCombinations = 0;
        //    for (int i = 0; i <= columnLength; i++)
        //    {
        //        totalCombinations += CombinationWithoutRepetition(i, columnLength);
        //    }

        //    //int[,] complimentColums

        //    return null;
        //}

        //n!/r!(n-r)!
        private static int[] FlipColumns(int columnLength)
        {
            //initialize column numbers
            int[] columnNumbers = new int[columnLength];
            for (int i = 0; i < columnNumbers.Length; i++)
            {
                columnNumbers[i] = i;
            }

            for (int i = 0; i <= columnLength; i++)
            {

            }

            return null;
        }



        //private static int GetCombinations(int choose, int columnLength)
        //{
        //    //List<List<int>> combinations = new List<List<int>>();
        //    if (choose == 1)
        //    {
        //        List<int> combinations = new List<int>();
        //        for (int i = 0; i <= columnLength; i++)
        //        {
        //            combinations.Add(i);
        //        }
        //    }

        //    return 0;
        //}
        private static int GetCombinations(int[] numbers, int digitLength, int combinationLength)
        {
            //List<List<int>> combinationList = new List<List<int>>();
            List<int> combination = new List<int>();

            int[,] combinationList = new int[combinationLength, digitLength];

            //for (int i = 0; i < combinationLength; i++)
            int loopCounter = 0;
            while(loopCounter < combinationLength)
            {
                combination.Clear();
                for (int j = 0; j < digitLength; j++)
                {
                    combination.Add(numbers[j]);
                }

                loopCounter++;
            }
            return 0;
        }

        private static int CombinationWithoutRepetition(int r, int n)
        {
            int nFact = Factorial(n);
            int rFact = Factorial(r);
            int nrFact = Factorial(n - r);

            return nFact / (rFact * nrFact);
        }
        private static int Factorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        /*NOT WORKING*/
        //public static int solution(int[,] matrix)
        //{
        //    int rowLength = matrix.GetLength(0); //3
        //    int columnLength = matrix.GetLength(1); //4
        //    int[] columnCounters = new int[columnLength];
        //    //List<int> columnCounters = new List<int>();
        //    int loopCounter = 0;
        //    int loopEnd = rowLength * columnLength;

        //    int colCount = 0; //cannot be more than 3

        //    while (loopCounter < loopEnd)
        //    {
        //        if (loopCounter > columnLength - 1)
        //        {
        //            for (int c = 0; c < columnCounters.Length; c++)
        //            {
        //                columnCounters[c] = columnCounters[c] != 0 ? 1 : 0;
        //                if (columnCounters[c] == 0)
        //                {
        //                    columnCounters[c]++;
        //                    break;
        //                }
        //            }

        //            int[,] newMatrix = ComplementMaxtrix(matrix, columnCounters
        //                                                .SkipWhile(cc => cc == 0).ToArray());
        //        }
        //        else
        //        {
        //            int[,] newMatrix = ComplementMaxtrix(matrix, columnCounters[colCount]);
        //            columnCounters[colCount] += 1;
        //        }

        //        loopCounter++;
        //    }

        //    //for (int i = 0; i < (rowLength * columnLength); i++)
        //    //{
        //    //    if (i > columnLength)
        //    //    {
        //    //        int diff = i - columnLength;


        //    //    }
        //    //    else
        //    //    {
        //    //        int[,] newMatrix = ComplementMaxtrix(matrix, i);
        //    //        columnCounters[i] += 1;
        //    //    }
        //    //}


        //    return 0;
        //}

        /// <summary>
        /// For multiple columns.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="columns"></param>
        /// <returns></returns>
        private static int[,] ComplementMaxtrix(int[,] matrix, int[] columns)
        {
            int rowLength = matrix.GetLength(0); //3

            for (int currRow = 0; currRow < rowLength; currRow++)
            {
                for (int i = 0; i < columns.Length; i++)
                {
                    matrix[currRow, columns[i]] = matrix[currRow, columns[i]] == 0 ? 1 : 0;
                }
            }

            return matrix;
        }
        private static int[,] ComplementMaxtrix(int[,] matrix, int column1, int column2)
        {
            int rowLength = matrix.GetLength(0); //3

            for (int currRow = 0; currRow < rowLength; currRow++)
            {
                matrix[currRow, column1] = matrix[currRow, column1] == 0 ? 1 : 0;
            }

            for (int currRow = 0; currRow < rowLength; currRow++)
            {
                matrix[currRow, column2] = matrix[currRow, column2] == 0 ? 1 : 0;
            }

            return matrix;
        }

        /// <summary>
        /// Produces a complement of specified column
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="column">If more than 1 column complement the matrix for 1st column then send again for 2nd.</param>
        /// <returns></returns>
        private static int[,] ComplementMaxtrix(int[,] matrix, int column)
        {
            int rowLength = matrix.GetLength(0); //3

            for (int currRow = 0; currRow < rowLength; currRow++)
            {
                matrix[currRow, column] = matrix[currRow, column] == 0 ? 1 : 0;
            }

            return matrix;
        }

        private static int CalculateMaxRows(int[,] matrix)
        {
            int rowLength = matrix.GetLength(0); //3
            int columnLength = matrix.GetLength(1); //4
            int rowSum = 0;
            int maxRows = 0;

            for (int currRow = 0; currRow < rowLength; currRow++)
            {
                for (int currColumn = 0; currColumn < columnLength; currColumn++)
                {
                    rowSum += matrix[currRow, currColumn];
                }

                if (rowSum % columnLength == 0) maxRows += 1;
                rowSum = 0;
            }

            return maxRows;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            int rowLength = matrix.GetLength(0); //3
            int columnLength = matrix.GetLength(1); //4

            for (int currRow = 0; currRow < rowLength; currRow++)
            {
                Console.Write($"Array row:{currRow} > ");

                for (int currColumn = 0; currColumn < columnLength; currColumn++)
                {
                    Console.Write($"{matrix[currRow, currColumn]}");
                }

                Console.Write("\n");
            }
        }


    }
}
