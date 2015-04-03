using Fact.Factory;
using Fact.Tests.Factory;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact.Tests
{
    [SetUpFixture]
    internal class FactInitializer
    {
        [SetUp]
        public void Before()
        {
            CustomerFactory.Build();
        }

        [TearDown]
        public void Down()
        {
            Builder.Current.Clear();
        }
    }
}
