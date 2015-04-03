using Fact.Specs;
using Fact.Tests.Domain.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact.Tests.Specs.Domain.Model
{
    [TestFixture]
    public class ContaBancariaSpec : SpecContext
    {
        private ContaBancaria conta;

        [Test]
        public void describe_conta_bancaria()
        {
            context["Dada uma conta bancária com saldo de R$ 100,00"] = () =>
            {
                before = () => conta = new ContaBancaria(100);

                context["quando debitar R$ 10,00"] = () =>
                {
                    before = () => conta.Debitar(10);

                    it["O Saldo anterior será 100"] = () => Assert.AreEqual(100, conta.SaldoAnterior);
                    it["O Saldo atual será 90"] = () => Assert.AreEqual(90, conta.Saldo);
                    it["O último lançamento será -10"] = () => Assert.AreEqual(-10, conta.UltimoLancamento);
                };

                context["quando creditar R$ 10,00"] = () =>
                {
                    before = () => conta.Creditar(10);

                    it["O Saldo anterior será 90"] = () => Assert.AreEqual(90, conta.SaldoAnterior);
                    it["O Saldo atual será 100"] = () => Assert.AreEqual(100, conta.Saldo);
                    it["O último lançamento será 10"] = () => Assert.AreEqual(10, conta.UltimoLancamento);
                };
            };

        }
    }
}
