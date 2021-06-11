using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        public readonly DateTime Nascimento; //READ ONLY No momento da construção do objetio seta um valor apenas para leitura,
                                      //depois de setado o valor nao pode mais ser alterado
       

        public Cliente(String nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;

            Nascimento = new DateTime(2020, 10, 10);
        }

        public string GetDataDeNascimento() {
            return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }

    class ReadOnly
    {
       
        public static void Executar() {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

        }
    }
}
