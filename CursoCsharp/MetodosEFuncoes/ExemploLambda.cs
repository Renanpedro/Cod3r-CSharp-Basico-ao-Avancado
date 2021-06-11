using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {   //Lambda é uma função anomima que é armazenada em uma variavel
        //action função void, função sem retorno
        //func função com retorno
        public static void Executar() {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");

            //Mesma coisa da linha 26, so que mais detalahado
            //Func<int, string> conversorhex = (numero) => {
            //    return numero.ToString("X");}

            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                string.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            Console.WriteLine(formatarData(1,1,2019));
        }
    }
}
