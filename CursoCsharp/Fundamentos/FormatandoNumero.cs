using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // arredonda o valor pra cima então ficaria 15.2
            Console.WriteLine(valor.ToString("C")); //transforma o valor em valor monetario
            Console.WriteLine(valor.ToString("P")); //Coloca em % e multiplica por 100
            Console.WriteLine(valor.ToString("#.##")); // irá colocar apenas duas casas decimais, as # conta quantas casas são ex: 15.17

            CultureInfo cultura = new CultureInfo("pt-BR");//Altera os caracteres especiais de acordo com o pais designado
            Console.WriteLine(valor.ToString("C0",cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));//Acrescenta os 000 a esquerda até fechar a quantidade de caract. escolhidos no caso foram 10
            
        }
    }
}
