using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2; // quandos os dois forem verdadeiros (&& E)
            Console.WriteLine("Comrpou a TV 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; //Quando um dos dois forem verdadeiros (|| OU)
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // (^ OU Exclusivo) Só se em dos dois forem Verdadeiro
            Console.WriteLine("Comprou a TV 32 {0}", comprouTv32);

            Console.WriteLine("Mais saudavel? {0}", !comprouSorvete); //! Negação logica inverte o resultado da var comprou sorverte
            //caso esteja true irá passar para false e caso esteja false ira passar para true

        }
    }
}
