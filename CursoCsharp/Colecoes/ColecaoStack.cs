using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecaoStack
    {
        //stack o ultimo atributo e o primeiro a aparecer
        //o ultimo a chegar e o primeiro a sair
        public static void Executar() {
            var pilha = new Stack();

            //push para adicionar algo na fila
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }

            // \nPop ira pegar o ultimo valor e remover ele da fila
            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha) {
                Console.Write($"{item}");
            }

            //peek pega o utlimo elemento, mas não remove ele da fila
                Console.WriteLine($"\nPeek: {pilha.Peek()}");
                Console.WriteLine(pilha.Count);
            
        }
    }
}
