using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    //CTRL + . (Em cima da classe para criar tarefas automaticas como (Construtor, GetHashcode para comparar elemetos e etc.) )
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Preco);
        }

        //comparando os objetos em si se são iguais, e não os espaços de memoria
        //public override bool Equals(object obj) {
        //    Produto outroProduto = (Produto)obj;
        //    bool mesmmoNome = Nome == outroProduto.Nome;
        //    bool mesmmoPreco = Preco == outroProduto.Preco;
        //    return mesmmoNome && mesmmoPreco;
        //}

        //public override int GetHashCode() {
        //    return Nome.Length;
        //}
    }
    class ColecoesList
    {
        public static void Executar() {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Bebida", 20)
            };

            //AddRange adiciona varios elementos de uma unica vez
            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            //RemoveAtt para remover um item especifico da lista
            carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
