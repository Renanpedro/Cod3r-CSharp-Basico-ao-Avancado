using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar() {
            
            //double nota = 6.0;
            double notaDeCorte = 7.0;

            Console.Write("Digite a sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            Console.WriteLine("A nota digita é inválida está acima de 10? {0}", nota > 10.0);
            Console.WriteLine("A nota digita é inválida está abaixo de 0? {0}", nota < 0.0);
            Console.WriteLine("Aprovado com Maestria tirou 10? {0}", nota == 10.0);

            //if (nota == 10.0)
            //{ Console.WriteLine("Aprovado com sucesso"); }

            //else {
            //    Console.WriteLine("Não foi com masestria");
            //}


            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);  // ! significa que a nota e diferente de 10
            Console.WriteLine("passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota < 3.0 );
            
        }
        
    }
}
