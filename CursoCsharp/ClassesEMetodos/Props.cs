using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional {
        double desconto = 0.1; // Quando não é declarado o nivel de acesso ele fica como PRIVATE ao invés de PUBLIC
        string nome;
        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
         }

        // Propriedade Autoimplementada
        public double Preco { get; set; }

        //somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); //Lambda
           
            // o codigo acima poderia ser descvrito desta forma
            //get {
            //    return  Preco - (desconto* Preco);}

        }

        public CarroOpcional() { 
        
        }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        
    } 

    class Props
    {
        public static void Executar() {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9); 
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349;

            #region Apresentar Dados na Tela
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
            #endregion

        }
    }
}
