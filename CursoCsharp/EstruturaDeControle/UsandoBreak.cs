using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class UsandoBreak
    {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next(1, 51);
            
            var corAtual = Console.BackgroundColor;
            Console.WriteLine("O numero que queremos é {0}", numero);

            for (int i = 1; i <= 50; i++) {
                Console.WriteLine($"{i} é o numero que queremos? ");
                if (i == numero)
                {
                    Console.WriteLine("Achamos o nosso numero");                                  
                    break;
                }
                else {
                    Console.WriteLine("Não é o numero que eu quero");
                }
            }
                        
            Console.WriteLine("Finalizamos");
            
        }
    }
}
