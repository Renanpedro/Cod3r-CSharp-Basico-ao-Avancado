using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{   // Não é possível instanciar uma classe abstract
    // So usa classe abstract caso tenha alguma classe que herda dela
    public abstract class Celular {
        public abstract string assistente();

        public string Tocar() {
            return "TRIM TRIM TRIM...";
        }
    
    }

    public class Samsung : Celular {
        //override para sobreescrever um metodo
        public override string assistente()
        {
            return "Olá! Meu nome é bixby";

        }
     }

    public class Iphone : Celular {
        public override string assistente()
        {
            return "Olá! meu nome é Siri";
        }
     }

    class Abstract
    {
        public static void Executar() {
            var celulares = new List<Celular> {
               new Iphone(),
               new Samsung()
              
           };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.assistente());
            }
        }
    }
}
