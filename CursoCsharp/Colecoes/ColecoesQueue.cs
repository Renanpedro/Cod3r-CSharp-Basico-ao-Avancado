using System;
using System.Collections.Generic;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        //queue serve para criar uma fila que aceita repetições
        //queue o primeiro a chegar e o primeiro a sair, o primeiro atributo inseriado sera o primeiro mostrado na tela
        public static void Executar() {
            var fila = new Queue<string>();

            //adicionar os usuários na fila
            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("beltrano");
            fila.Enqueue("beltrano");

            //mostra o proximo elemento da fila, o 1, mas nao exclui ele da fila
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            //DeQueue retira o primeiro da fila
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue("Renan");
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);
            salada.Enqueue("Renan");

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));

        }
    }
}
