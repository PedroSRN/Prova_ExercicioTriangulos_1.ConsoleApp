using System;

namespace Prova1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val1, val2, val3, opcao;

            while (true)
            {

                Console.WriteLine("Calculadora de Triangulos");
                Console.WriteLine("***************************");
                Console.WriteLine("1 - Calcular ");
                Console.WriteLine("2- Sair ");
                Console.WriteLine("------------------");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (opcao == 1)
                {
                    Console.WriteLine("Digite o primeiro valor do triângulo: ");
                    val1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o segundo valor do triângulo: ");
                    val2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite o terceiro valor do triângulo: ");
                    val3 = Convert.ToInt32(Console.ReadLine());


                    if (val1 + val2 > val3 && val1 + val3 > val2 && val2 + val3 > val1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("É Triângulo");
                        Console.WriteLine("");


                        if (val1 != val2 && val1 != val3 && val2 != val3)
                        {
                            Console.WriteLine("Triângulo Escaleno");
                            Console.WriteLine("");
                        }
                        else if (val1 == val2 && val1 == val3 && val2 == val3)
                        {
                            Console.WriteLine("Triângulo Equílatero");
                            Console.WriteLine("");
                        }
                        else if (val1 == val2 && val1 != val3 || val3 == val2 && val1 != val2 || val1 == val3 && val1 != val2)
                        {
                            Console.WriteLine("Triângulo Isóceles");
                            Console.WriteLine("");
                        }

                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Não é triangulo Por favor Informe outros valores");
                        Console.WriteLine("");
                        continue;
                    }
                }
                else if(opcao == 2 || opcao != 1 || opcao != 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Você está saindo, Obrigado por usar nossa calculadora");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
