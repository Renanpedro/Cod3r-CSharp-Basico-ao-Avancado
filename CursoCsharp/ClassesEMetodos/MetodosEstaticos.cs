using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica {
      
        //  Método de classe ou método estático
        public static int Multiplicar(int a, int b) {
            return a * b;
        }

        // Método de instância
        public int somar(int a, int b)
        {
            return a + b;
        }


    }

    class MetodosEstaticos
    {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}",resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.somar(2,2));
            Console.WriteLine("Resultado: {0}",resultado);
        }
    }
}
