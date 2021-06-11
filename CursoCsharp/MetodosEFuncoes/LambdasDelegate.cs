using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);

    class LambdasDelegate
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(3, 3));
            Console.WriteLine(sub(5, 2));
            Console.WriteLine(mult(12, 8));
        }

    }

    //abaixo é meu exemplo solo
    //class calc { 
    //    public static void Executar()
    //    {
    //        Operacao sum2 = (x, y) => x + y;
    //        Operacao sub = (x, y) => x - y;

    //        Console.WriteLine(sum2(2, 2));
    //        Console.WriteLine(sub(10,2));

    //    }
    //}
}
