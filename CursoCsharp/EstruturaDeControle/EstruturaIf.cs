using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIf
    {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a entrada: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);


            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            //bomComportament = entrada == "S" || entrada == "s";
            bomComportamento = entrada.ToLower() == "s"; //ToLower para deixar todas as letras minusculas

            if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de Honra!");
            }


            

        }
        
    }
}
