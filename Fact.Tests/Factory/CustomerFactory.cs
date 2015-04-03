using Fact.Factory;
using Fact.Tests.Domain.Model;

namespace Fact.Tests.Factory
{
    internal class CustomerFactory
    {
        public static void Build()
        {
            Builder.Current.Set(new Customer
            {
                Id = "build-test-01",
                Address = Faker.BR.AddressBR.Address,
                Email = Faker.Internet.Email("customer"),
                Name = Faker.Name.FullName,
                Site = Faker.Internet.HttpUri
            });



            Builder.Current.Set("without email",
                new Customer
                {
                    Id = "build-test-02",
                    Address = Faker.BR.AddressBR.Address,
                    Name = Faker.Name.FullName,
                    Site = Faker.Internet.HttpUri
                });
        }
    }
}
