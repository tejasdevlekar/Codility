using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Codility
{
    public class FrogJump
    {
        public static int solution3(int X, int Y, int D)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (X > Y) return 0;

            int lastRemainingDistance = Y % D;
            int jumpMultiplier = Y / D;

            int jumps = lastRemainingDistance == 0 ? jumpMultiplier : jumpMultiplier + 1;

            sw.Stop();
            Console.WriteLine($"Elasped time: {sw.Elapsed}");
            return jumps;
        }

        public static int solution2(int X, int Y, int D)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (X > Y) return 0;

            int jumps = 0;
            while (X < Y)
            {
                X += D;
                jumps++;
            }

            sw.Stop();
            Console.WriteLine($"Elasped time: {sw.Elapsed}");
            return jumps;
        }
        public static int solution(int X, int Y, int D)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            if (X > Y) return 0;
            int multiplier = Y / D;

            X = X + D * multiplier;

            int jumps = multiplier;
            while (X < Y)
            {
                X += D;
                jumps++;
            }

            sw.Stop();
            Console.WriteLine($"Elasped time: {sw.Elapsed}");

            return jumps;
        }
    }
}
