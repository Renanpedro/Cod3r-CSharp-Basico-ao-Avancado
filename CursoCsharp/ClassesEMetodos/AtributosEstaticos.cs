using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class AtributosEstaticos
    {
        public class Produto {
            public string Nome;
            public double Preco;
            public static double Desconto = 0.5;

            public Produto(String nome, double preco, double desconto) {
                Nome = nome;
                Preco = preco;
                Desconto = desconto;
            }

            public Produto() { 
            
            }

            public double CalcularDesconto() {
                return Preco - Preco * Desconto;
            }
        }

        public static void Executar() {

            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
                
            };

            Produto.Desconto = 0.05;

            Console.WriteLine("preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("preço com desconto: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.002;

            Console.WriteLine($"Preço com desconto: {produto1.CalcularDesconto()}");
            Console.WriteLine($"Preco com Desconto: {produto2.CalcularDesconto()}");

        }
    }
}
