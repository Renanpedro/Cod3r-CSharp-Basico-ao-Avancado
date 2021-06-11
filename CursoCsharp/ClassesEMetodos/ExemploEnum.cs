using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero{Acao, Aventura, Terror, Animacao, Comedia};
    //Com enum é possível setar valores já definidos apenas para serem apresentados, não é possivel realizar a alteração

    public class Filme{
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    class ExemploEnum
    {
        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeparaFamilia = new Filme();
            filmeparaFamilia.Titulo = "Sharknardo 17";
            filmeparaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1},", filmeparaFamilia.Titulo, filmeparaFamilia.GeneroDoFilme);
        }
    }
}
