using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aggregates.Model
{
    public static class RndData
    {
        // source http://stackoverflow.com/questions/1122483/c-sharp-random-string-generator
        private static readonly Random Rnd = new Random(Guid.NewGuid().GetHashCode());

        public static string GetString()
        {
            return GetString(100);
        }

        public static string GetString(int size)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                char ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * Rnd.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        public static int GetInt()
        {
            return Rnd.Next();
        }

        public static int GetInt(int max)
        {
            return Rnd.Next(0, max);
        }

        public static bool GetBool()
        {
            return Rnd.Next(2) == 1;
        }

        public static List<T> GetList<T>(int maxSize, Func<T> createFn)
            where T: class 
        {
            var size = GetInt(maxSize);
            if (size == 0)
                return new List<T>();

            return new List<T>(Enumerable.Range(1, size).Select(x=>createFn()));
        }
    }
}
