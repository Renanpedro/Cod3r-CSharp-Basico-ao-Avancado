using System;
using System.Globalization; //Biblioteca para não olhar os simbolos ( . e , ) de acordo com a localidade, irá utilziar o . como separador de casa decimal

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar() {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine()); //Converter um texto em uma String

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} {salario}");
        }
    }
}
