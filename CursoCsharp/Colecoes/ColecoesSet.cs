using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
     class colecoesSet
    {
        public static void Executar() {
            var livro = new Produto("Game of Throne", 49.9);

            //HashSet NÃO é indexado e NÃO aceita repetição
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            //HashSet NÃO é indexado e NÃO aceita repetição
            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10),
                new Produto("Bebida", 20)
            };

            //UnionWith adiciona varios elementos de uma unica vez
            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //RemoveAtt para remover um item especifico da lista
            //carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine("O seu carrinho contém: " + carrinho.Count + " itens");
            carrinho.Add(livro);
            Console.WriteLine("O seu carrinho contém: " + carrinho.Count + " itens");
            //Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
