using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDicionary
    {
        public static void Executar() {
            //Ao criar um dictionary na parte da chave INT nao aceita repetição, mas na parte do valor string aceita repetição
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-aranha");
            filmes.Add(2004, "Os incriveis");
            filmes.Add(2006, "O grande truque");

            if (filmes.ContainsKey(2004)) {
                //irá pegar o valor com base na chave 2004, caso nao ache a chave ira dar erro
                Console.WriteLine("2004: " + filmes[2004]);

                // Com o GetValueOrDefault caso ele não ache a chave ira trazer 0 default
                Console.WriteLine("2004: "  + filmes.GetValueOrDefault(2004));
            }

            // o ContainsValue irá verificar se dentro do dicionario exixte este valor
            Console.WriteLine(filmes.ContainsValue("amnésia"));

            // o Remove irá remover caso exista a chave passada
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}" );


            // O TryGetValue ira pegar a chave, colocar ela numa variavel passando por referencia, caso nao exista a chave ele traz 0
            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme {filme2006}!");


            // O foreach irá trazer apenas a chave que seria o ano dos filmes
            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }

            // O foreach irá trazer apenas o valor que seria o nome dos filmes
            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }

            // Para trazer Ano e nome do filme da forma mais dificil
            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            // Para trazer Ano e nome do filme da forma mais facil possíver
            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
