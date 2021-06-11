using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); //inverte o sinal
            Console.WriteLine(!booleano); //inverte o verdadeiro e falso

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);


            Console.WriteLine(numero1++ == --numero2); //Ele irá fazer o -- primeiro comparar os dois numeros e depois que acresnceta
            //o ++ na variavel numero1
            Console.WriteLine($"{numero1} {numero2}");
        
        }


    }
}
