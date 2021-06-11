using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class UsandoContinue
    {
        public static void Executar() {
            int intervalo = 50;
            Console.Write("Numeros pares entre 1 e {0}!",intervalo);
            Console.WriteLine(" ");

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) {
                    continue;
                }

                Console.Write(i + " ");
            }

                Console.WriteLine(" ");

            //Uma forma mais rapida de fazer os numeros pares

            //for (int i = 2; i <= intervalo; i += 2)
            //{
            //    Console.Write(i + " ");
            //}

        }
    }
}
