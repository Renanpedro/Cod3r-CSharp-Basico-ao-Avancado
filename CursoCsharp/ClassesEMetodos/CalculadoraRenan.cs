using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraRenan
    {

        public static void Executar()
        {
            double resultado;
            string entrada;
            

            do
            {
                Console.WriteLine("Qual operação vc deseja realizar?");
                Console.WriteLine("0 - Somar");
                Console.WriteLine("1 - Subtrair");
                Console.WriteLine("2 - Multiplicar");
                Console.WriteLine("3 - Dividir");
                int.TryParse(Console.ReadLine(), out int escolha);



                switch (escolha)
                {

                    case 0:
                        Console.WriteLine("Digite o primeiro numero: ");
                        double.TryParse(Console.ReadLine(), out double a);
                        Console.WriteLine("Digite o segunda numero: ");
                        double.TryParse(Console.ReadLine(), out double b);

                        resultado = a + b;
                        Console.WriteLine("A soma de {0} + {1} é: {2}", a, b, resultado);

                        break;

                    case 1:
                        Console.WriteLine("Digite o primeiro numero: ");
                        double.TryParse(Console.ReadLine(), out double c);

                        Console.WriteLine("Digite o segundo numero: ");
                        double.TryParse(Console.ReadLine(), out double d);

                        resultado = c - d;
                        Console.WriteLine("A subtração de {0} - {1} é : {2}", c, d, resultado);
                        break;

                    case 2:
                        Console.WriteLine("Digite o primeiro numero: ");
                        double.TryParse(Console.ReadLine(), out double e);
                        Console.WriteLine("Digite o segundo numero: ");
                        double.TryParse(Console.ReadLine(), out double f);

                        resultado = e * f;
                        Console.WriteLine("A multiplicação de {0} * {1} : é {2}", e, f, resultado);
                        break;

                    case 3:

                        
                        Console.WriteLine("Digite o primeiro numero: ");
                            double.TryParse(Console.ReadLine(), out double h); ;

                          

                        Console.WriteLine("Digite o segundo numero: ");
                        double.TryParse(Console.ReadLine(), out double i);

                      

                        resultado = h / i;
                        Console.WriteLine("A divisão de {0} / {1} é : {2}", h, i, resultado);
                        break;

                    default:
                        Console.WriteLine("Opção inválida, digite uma opção correta");
                        break;

                }

                Console.WriteLine("Deseja realizar outra conta? (S/N)");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() == "s" || entrada == "S");

            Console.WriteLine("Obrigado por testar o nosso Programa");
        }
    }

    //Console.WriteLine($"A soma dos numeros é: " + SOMAR(2,5)); ;
    //Console.WriteLine(Multiplicar(5,5));
    //Console.WriteLine(SUBTRAIR(10,5));
}


