using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    public class Conta {
        double Saldo;

        public Conta(Double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if (valor > Saldo) {
                throw new ArgumentException("Saldo Insuficiente.");
            }

            Saldo -= valor;
        }
    }
    class PrimeiraExcecao
    {
        public static void Executar() {
            var conta = new Conta(1_223.45);

            try{
                conta.Sacar(1600);
                Console.WriteLine("Retirado com sucesso!");
            } catch (ArgumentException ex) {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                // o Finally sempre ira aparecer, oq muda é o try e catch de acordo com a ação
            } finally {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
