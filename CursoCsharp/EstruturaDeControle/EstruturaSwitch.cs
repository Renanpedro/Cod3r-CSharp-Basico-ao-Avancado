﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendiemnto com uma nota de 1 a 5");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Pessimo");
                    break;

                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;

                case 3:
                    Console.WriteLine("Regular");
                    break;

                case 4:
                    Console.WriteLine("Bom");
                    break;

                case 5:
                    Console.WriteLine("ótimo");
                    break;

                default:
                    Console.WriteLine("Nota inválida, é de 1 a 5 o seu animal!!!!");
                    break;
            }
            Console.WriteLine("Obrigado por responder");

        }
    }
}
