using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar() {
            var saudacao = "Olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length); //Length pega a quantidade de caracteres

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length); //Colocar o ? pq se a variavel estiver vazia ele nao ira fazer nada ira ignorar
            //caso ela esteja vazia e ele tente contar os caracteres ira dar erro

        }
    }
}
