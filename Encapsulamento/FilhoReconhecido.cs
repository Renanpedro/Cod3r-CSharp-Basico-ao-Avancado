using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos() {
            Console.WriteLine("Filho Reconhecido");

            Console.WriteLine(infopublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
