using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaFor
    {
        public static void Executar() {
            //COMO É FEITO UTILIZANDO O WHILE
            //int i = 1;

            //while (i <= 10) {
            //    Console.WriteLine($"O valor de i é {i}.");
            //    i++;
            //}

            //COMO PODE SER FEITO COM O FOR
            //for (int i = 0; i <=10; i++) {
            //    Console.WriteLine($"O número de i é {i}.");
            //}

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.WriteLine("informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                if (notaAtual <= 10)
                {
                    somatorio += notaAtual;
                }
                else {
                    Console.WriteLine($"Nota inválida, digite uma nota abaixo de 10 novamente para o aluno {i}");
                    i--;
                }
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine($"Média da turma é: {media} ");

        }
    }
}
