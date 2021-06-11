using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        //array são elementos indexados ou seja são acessados atraves do indice
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Renan";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.0, 9.5, 5.4 };

            foreach (var nota in notas) {
                somatorio += nota;
            }

            //Length o tamanho do array,somatrio dividido por quantas posi~ções tem o array
            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };

            //Mostra uma letra abaixo da outra
            //foreach (var letra in letras) {
            //    Console.WriteLine(letra);
            //}

            //Mostrar a palavra completas
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
