using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Filho Não Reconhecido...");

            Console.WriteLine(infopublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
        }
    }

    public class AmigoDistante {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcesso() {
            Console.WriteLine("Amigo distante....");

            Console.WriteLine(amiga.infopublica);
            //Console.WriteLine(amiga.CorDoOlho);
            //Console.WriteLine(amiga.NumeroCelular);
            //Console.WriteLine(amiga.JeitoFalar);
            //Console.WriteLine(amiga.SegradoFamilia);
            //Console.WriteLine(amiga.UsaMuitoPhotoshop);
        }
    }

    class Encapsulamento
    {
        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            Console.WriteLine("......");
            new FilhoNaoReconhecido().MeusAcessos();

            Console.WriteLine("......");
            new AmigoProximo().MeusAcessos();

            Console.WriteLine("......");
            new FilhoNaoReconhecido().MeusAcessos();

            Console.WriteLine("......");
            new AmigoDistante().MeusAcesso();
            
        }
    }
}
