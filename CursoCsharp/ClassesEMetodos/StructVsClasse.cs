﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }

    class StructVsClasse
    {
        //Ao realizar a atriubição pela Struct o mesmo salva os valores em locais diferente da memoria
        //Na classe ao realziar a atriubição ele salva os valores no mesmo local da memoria

        public static void Executar() {
            SPonto ponto1 = new SPonto{ X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; //Atribuição por valor
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}",ponto1.X);
            Console.WriteLine("Copia ponto 1 X:{0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; //Atribuição por Referência
            copiaPonto2.X = 4;

            Console.WriteLine("Ponto 2 X:{0}",ponto2.X);
            Console.WriteLine("Copia Ponto 2 X:{0}", copiaPonto2.X);
        }
    }
}
