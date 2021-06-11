using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }

        public int Divisão(int a, int b) {
            return a / b;
        }
    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Dividir(int a) {
            memoria /= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar() {
            var calculadoraComun = new CalculadoraComum();
            var resultado = calculadoraComun.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComun.Subtrair(10, 5));
            Console.WriteLine(calculadoraComun.Multiplicar(5, 5));
            Console.WriteLine(calculadoraComun.Divisão(4,2));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();


            var resultadoCadeia = calculadoraCadeia.Somar(10).Multiplicar(2).Resultado();
            Console.WriteLine(resultadoCadeia);

            resultadoCadeia = calculadoraCadeia.Somar(5).Multiplicar(2).Dividir(1).Subtrair(0).Resultado();
            Console.WriteLine(resultadoCadeia);
        }
    }
}
