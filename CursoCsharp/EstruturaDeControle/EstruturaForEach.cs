﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForEach
    {
        public static void Executar() {
            var palavra = "OPA!";

            foreach (var letra in palavra){
                Console.WriteLine(letra);
            }

            var alunos = new string[] { "Ana", "Bia", "Carlos" };

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno); 
           }

        }
    }
}
