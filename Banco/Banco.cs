using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoNameSpace
{
    public class Caixa
    {
        public int Saldo { get; set; }
        public string NomeDoUsuario { get; set; }

        public Caixa()
        {
            Saldo = 1000;
            NomeDoUsuario = "Joao";
        }

        public int AdcionarDinheiro(int a)
        {
            Saldo += a;
            return Saldo;
        }

        public int RetirarDinheiro(int a)
        {
            if(Saldo < a)
            {
                throw new Exception();
            }
            else
            {
                Saldo -= a;
                return Saldo;
            }
        }

        public decimal CalculoJurosEmprestimo(decimal a, int parcelamento)
        {
            decimal juros = (a * 0.2M) / parcelamento;
            decimal valorPagamentoParcelado = (a / parcelamento) + juros;

            return valorPagamentoParcelado;
        }

        public decimal PedirEmprestimo(int a, int parcelamento)
        {
            if(parcelamento > 12)
            {
                throw new Exception("Você só pode parcelar ate 12 vezes");
            }
            else
            {
                Saldo += a;
                decimal valorPagamentoParcelado = CalculoJurosEmprestimo(a, parcelamento);
                Console.WriteLine($"Você vai pagar R${valorPagamentoParcelado:F2} durante {parcelamento} meses, sob uma taxa de 20% sobre o valor total");
                return Saldo;
            }
        }


    }
}
