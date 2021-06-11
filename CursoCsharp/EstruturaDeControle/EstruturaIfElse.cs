using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;
            //double nota2 = 7;

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Não fez mais que a obrigação..");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }


            //if (nota2 <= 3.0)
            //{
            //    Console.WriteLine("Reprovado");
            //}
            //else if (nota2 == 5 && nota2 <= 6)
            //{
            //    Console.WriteLine("Recuperação");
            //}
            //else if (nota2 >= 7) {
            //    Console.WriteLine("Aprovado");
            //}



        }
    }
}
