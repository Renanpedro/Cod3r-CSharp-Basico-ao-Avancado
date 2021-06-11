using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }
    class ValorVsReferencia
    {       
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "beto",
                Idade = 20
            };

            Dependente copiadep = dep;

            Console.WriteLine($"{dep.Nome} {copiadep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiadep.Idade}");

            copiadep.Nome = "Renato";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Nome} {copiadep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiadep.Idade}");

        }
    }
}
