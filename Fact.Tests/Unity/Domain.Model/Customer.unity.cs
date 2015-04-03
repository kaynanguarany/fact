using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Fact.Tests.Domain.Model;
using Fact.Factory;

namespace Fact.Tests.Unity.Domain.Model
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        [Description("Testando funcionamento do Builder")]
        public void BuildDeCustumer()
        {
            var customer = Builder.Current.Build<Customer>();
            var customerWithoutEmail = Builder.Current.Build<Customer>("without email");
            
            Assert.AreEqual("build-test-01", customer.Id);
            Assert.AreEqual("build-test-02", customerWithoutEmail.Id);
        }
    }
}
