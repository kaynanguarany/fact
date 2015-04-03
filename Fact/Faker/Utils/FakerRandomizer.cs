using System;
using System.Linq;

namespace Fact.Faker.Utils
{
    internal static class NFakerRandomizer
    {
        private static readonly Random random = new Random();

        public static string Rand(this string[] value)
        {
            var index = value.Count().Randomize();
            return value[index];
        }

        public static object[] Rand(this object[,] values)
        {
            var index = values.GetLength(0).Randomize();

            return new object[]
            {
                values.GetValue(index, 0),
                values.GetValue(index, 1)
            };
        }

        public static double[] Rand(this double[,] values)
        {
            var index = values.GetLength(0).Randomize();

            return new double[]
            {
                (double)values.GetValue(index, 0),
                (double)values.GetValue(index, 1)
            };
        }

        public static string Rand(this string value, char separator = ' ')
        {
            return value.Split(separator).Rand();
        }

        public static int Randomize(this int max)
        {
            return random.Next(0, max);
        }
    }
}
