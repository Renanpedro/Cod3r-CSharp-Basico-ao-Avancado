using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar() {
            // area da circuferência
            double raio = 4.5; //Variavel de valor decimal ou inteiro
            const double PI = 3.14;

            raio = 5.5;


            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);


            bool estaChovendo = true; //Variavél de Verdadeiro ou Falso
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45; //Armazena apenas valores positivos 
            Console.WriteLine("idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue; //Variavel mais utilizada
            Console.WriteLine("Menor valor do inteiro "+ menorValorInt);

            uint populacaoBrasileira = 207_600_000; //Inteiro sem Sinal
            Console.WriteLine("População brasileira é " +populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f; //Espera valores reais com o F no final, senão ele indica colocar a variavel como Double
            Console.WriteLine("Preço do computador "+ precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000.00; //Variavel Mais utilizada
            Console.WriteLine("Valor Apple: " + valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue; //Aceita valores astronomicos valor muito grandes
            Console.WriteLine("Distancia entre as estrelas :" + distanciaEntreEstrelas);

            char letra = 'b'; //Aceita uma letra
            Console.WriteLine("letra " + letra);

            string texto = "Seja bem vindo ao curso de C#";
            Console.WriteLine(texto);


        }
    }
}
