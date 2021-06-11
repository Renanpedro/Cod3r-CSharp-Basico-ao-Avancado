using System;
using System.Collections.Generic;
using System.Text;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T> {
        T valorPrivado;
        public T Coisa { get; set; }

        public Caixa(T coisa) {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor) {
            //se o resultado for 0 retorna oq estiver dentro de coisa, se o valor for 1 retorna valor
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor() {
            return valorPrivado;
        }
    }

    //ao herdar a classe generica, já está sendo passado que T ira virar INT
    class CaixaInt : Caixa<int> {
        public CaixaInt() : base(0) { 
            
        }
    }

    class Genericos
    {
        public static void Executar() {
            var caixa1 = new Caixa<int>(1000);

            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("Construtor");
            Console.WriteLine(caixa2.metodoGenerico("metodo"));
            Console.WriteLine(caixa2.GetType());
        }
    }
}
