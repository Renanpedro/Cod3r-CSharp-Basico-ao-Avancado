using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;

            //comparando o endereço de memoria
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p3 == p2);

            Console.WriteLine(p1.Equals(p2));

            // GetHashCode comparando os objetos em si se são iguais, e não os espaços de memoria
            // o codigo está na classe de produto
        }


    }
}
