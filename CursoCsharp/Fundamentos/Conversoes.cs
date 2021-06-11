using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar() {
            int inteiro = 10;
            double quebrado;
            quebrado = inteiro;
            Console.WriteLine(quebrado);


            double nota = 9.7;
            int notaTruncada = (int) nota; //converter um valor Double para int
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.WriteLine("Digite a sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}",idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}",idadeInteiro);

            Console.WriteLine("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1); //converter oq estiver em palavra e colcoar o resultado dentro do numero
            Console.WriteLine("Resultado: {0}",numero1);

            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado: {0}", numero2);

        }
    }
}
