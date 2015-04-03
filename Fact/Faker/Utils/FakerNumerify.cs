using System.Linq;

namespace Fact.Faker.Utils
{
    internal static class FakerNumerify
    {
        public static string Numerify(this string value)
        {
            var number = string.Empty;
            foreach (var item in value.ToList())
            {
                number += item.ToString().Replace("#", 10.Randomize().ToString());

            }

            return number;
        }
    }
}
