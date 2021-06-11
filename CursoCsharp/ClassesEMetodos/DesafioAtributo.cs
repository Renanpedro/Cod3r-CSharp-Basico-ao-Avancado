using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 25;

        public static void Executar() {
            // acessar a variável 'a' dentro do método Executar!

            DesafioAtributo classe = new DesafioAtributo();
            Console.WriteLine(classe.a);
        }
    }
}
