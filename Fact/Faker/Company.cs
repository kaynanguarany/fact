using Fact.Faker.Utils;

namespace Fact.Faker
{
    public class Company
    {
        private static string[] SUFFIXES = { "Inc", "Inc and Sons", "LLC", "Group" };

        public static string Name
        {
            get
            {
                switch (3.Randomize())
                {
                    case 0: return $"{Faker.Name.LasttName} {SUFFIXES.Rand()}";
                    case 1: return string.Format("{0}-{1}", Faker.Name.LasttName, Faker.Name.LasttName, SUFFIXES.Rand());
                    case 2: return string.Format("{0}, {1} and {2}", Faker.Name.LasttName, Faker.Name.LasttName, Faker.Name.LasttName);
                    default: return string.Empty;
                }
            }
        }
    }
}
