using System;

namespace AggregatesGen
{
    static class RandomGen
    {
        static readonly Random Rnd = new Random(Guid.NewGuid().GetHashCode());

        public static string GetRandomPropertyName()
        {
            return "Prop" + Guid.NewGuid().ToString("N");
        }

        public static string GetRandomClassName()
        {
            return "Class" + Guid.NewGuid().ToString("N");
        }

        public static string PickRandomValue(params string[] values)
        {
            return values[Rnd.Next(0, values.Length)];
        }

        public static bool IsLucky(int invProbab)
        {
            if (invProbab < 1)
                return true;
            return PickNumber(1, invProbab) == 1;
        }

        public static int PickNumber(int max)
        {
            return PickNumber(0, max);
        }

        public static int PickNumber(int min, int max)
        {
            return Rnd.Next(min, max + 1);
        }
    }
}