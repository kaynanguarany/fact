using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fact.Tests.Domain.Model
{
    public class ContaBancaria
    {
        public double Saldo { get; private set; }
        public double UltimoLancamento { get; private set; }
        public double SaldoAnterior { get; private set; }

        public ContaBancaria(double saldo)
        {
            this.Saldo = saldo;
        }

        public void Debitar(double valor)
        {
            this.SaldoAnterior = this.Saldo;
            this.Saldo -= valor;
            this.UltimoLancamento = valor * -1;
        }

        public void Creditar(double valor)
        {
            this.SaldoAnterior = this.Saldo;
            this.Saldo += valor;
            this.UltimoLancamento = valor;
        }
    }
}
