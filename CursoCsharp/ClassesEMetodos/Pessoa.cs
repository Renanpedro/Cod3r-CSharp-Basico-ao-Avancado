using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Aprensentar() {
            if (Idade <= 0)
            {
                return string.Format("os dados não estão preenchidos!");
                
                

            }
            else { return string.Format($"Olá! me chamo {Nome} tenho {Idade} anos. ");  }
            
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Aprensentar());
        }

        public void Zerar() {
            Nome = " ";
            Idade = 0;
        }
    }
}
