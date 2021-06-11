using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos podem acessar
        public string infopublica = "Tenho um instagram!";

        // herança
        protected string CorDoOlho = "Verde";

        // mesmo projeto (assembly)
        internal ulong NumeroCelular = 551199999999;

        // herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // mesma class ou herança no mesmo projeto (C# >=7.2)
        private protected string SegredoFamilia = "Bla bla";

        // private é o padrão só na mesma classe
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(infopublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);

        }


    }
}
