using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar() {
            var nota = 6.0;
            bool bomComportamento = true;
            string resutado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            //se nota for maior que 7 e bom comportamento for true sera aprovado, caso contrario será reprovado.
            Console.WriteLine(resutado);
        }
    }
}
