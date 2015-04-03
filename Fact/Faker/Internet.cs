using Fact.Faker;
using Fact.Faker.Utils;
using System.Linq;

namespace Fact.Faker
{
    public static class Internet
    {
        public static string HttpUri => 
            Uri("http");

        public static string DomainName =>
            string.Format("{0}.{1}", Company.Name.Split(' ').First().ToLower(), DOMAIN_SUFFIXES.Rand());

        public static string IpV4 =>
            string.Format("{0}.{1}.{2}.{3}", 255.Randomize(), 255.Randomize(), 255.Randomize(), 255.Randomize());


        public static string Email(string name)
        {
            return string.Join("@", name, HOSTS.Rand());
        }

        public static string DisposableEmail(string name)
        {
            return string.Join("@", name, DISPOSABLE_HOSTS.Rand());
        }

        public static string Uri(string protocol)
        {
            return string.Format("{0}://{1}", protocol, DomainName);
        }


        private static string HOSTS = "gmail.com yahoo.com hotmail.com";
        private static string DISPOSABLE_HOSTS = "mailinator.com suremail.info spamherelots.com binkmail.com safetymail.info";
        private static string DOMAIN_SUFFIXES = "co.uk com us ca biz info name";
    }
}
