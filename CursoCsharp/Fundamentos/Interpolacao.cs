using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {

        public static void Executar() {
            string nome = "Notebook Gamer";
            var marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " Custa " + preco + ".");
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome,marca,preco);
            Console.WriteLine($"A marca {marca} é legal!");
            Console.WriteLine($"1+1 = {1+1}!");


            string eu = "Renan Pedro";
            int idade = 23;
            var estado_civil = "Casado";

            Console.WriteLine("Eu " + eu + " tenho " +idade+ " e sou " + estado_civil);
            Console.WriteLine("Eu {0} tenho {1} e sou {2}",eu,idade,estado_civil);
            Console.WriteLine($"Eu {eu} tenho {idade} e sou {estado_civil}");

        }
    }
}
