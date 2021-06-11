using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    class Sealed
    {
        public class SemFilho {
            public double ValorDaFortuna() {
                return 1_407_033.65;
            }
        }

        //class SouFilho : SemFilho { 

        //}

        class Avo {
            public virtual bool HonrarNomeFamilia() {
                return true;
            }
        }

        class Pai : Avo {
            //sealed deixa o metodo selado, não podendo ser alterado
            public override sealed bool HonrarNomeFamilia()
            {
                return true;
            }
        }

        class FilhoRebelde : Pai {
            //public override bool HonrarNomeFamilia() {
            //    return false;
            //}
        }

        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
