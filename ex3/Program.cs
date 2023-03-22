using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====MENU=====");
            Console.WriteLine("1 - exercicio1");
            Console.WriteLine("2 - exercicio1");
            Console.WriteLine("3 - exercicio1");
            Console.WriteLine("4 - exercicio1");
            Console.WriteLine("5 - exercicio1");
            Console.WriteLine("6 - exercicio1");
            Console.WriteLine("==============");

            int exerciciu = int.Parse(Console.ReadLine());

            switch (exerciciu)
            {
                case 1:
                    Console.WriteLine("exerciou 1 executando");
                    int D; Console.WriteLine("Escolha um dia da semana de 1 à 7"); D = int.Parse(Console.ReadLine());
                    switch (D)
                    {
                        case 1:
                            Console.WriteLine("Domingo");
                            break;
                        case 2:
                            Console.WriteLine("Segunda-Feira");
                            break;
                        case 3:
                            Console.WriteLine("Terca-Feira");
                            break;
                        case 4:
                            Console.WriteLine("Quarta-Feira");
                            break;
                        case 5:
                            Console.WriteLine("Quinta-Feira");
                            break;
                        case 6:
                            Console.WriteLine("Sexta-Feira");
                            break;
                        case 7:
                            Console.WriteLine("Sábado");
                            break;
                            Console.ReadKey();
                    }
                break;
                //---------------------------------------------------------------------------------------------------------------------------------------------
                case 2:
                    Console.WriteLine("exerciou 2 executando");

                    Console.WriteLine("quanto vocé pagou:");
                    double valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("qual o pagamento");
                    string MET = (Console.ReadLine());
                    double res;
                    if (MET == "dinheiro") 
                    {
                        res = valor - (valor * 0.15) ;
                        Console.WriteLine("o valor final sera:"+ res);
                    }
                    else if (MET == "PIX")
                    {
                        res = valor - (valor * 0.5);
                        Console.WriteLine("o valor final sera:" + res);
                    }
                    else if (MET  == "débito")
                    {
                        res = valor - (valor * 0.5);
                        Console.WriteLine("o valor final sera:" + res);
                    }
                    else if (MET == "débito")
                    {
                        res = valor - (valor * 0.10);
                        Console.WriteLine("o valor final sera:" + res);
                    }
                    else
                    {
                        Console.WriteLine("não á esse metodo de pagamento");
                    }
                    Console.ReadKey();
                    break; 

                //-----------------------------------------------------------------------------------------------------------------------------------------
                case 3:
                    Console.WriteLine("exerciou 3 executando");
                    Console.Write("Digite um número de 1 a 12 para representar um mês: ");
                    int mes = int.Parse(Console.ReadLine());

                    switch (mes)
                    {
                        case 1:
                            Console.WriteLine("Janeiro tem 31 dias");
                            break;
                        case 2:
                            Console.Write("Digite o ano: ");
                            int ano = int.Parse(Console.ReadLine());
                            if ( ano % 400 == 0)
                            {
                                Console.WriteLine("Fevereiro tem 29 dias");
                            }
                            else
                            {
                                Console.WriteLine("Fevereiro tem 28 dias");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Março tem 31 dias");
                            break;
                        case 4:
                            Console.WriteLine("Abril tem 31 dias");
                            break;
                        case 5:
                            Console.WriteLine("Abril tem 30 dias");
                            break;
                        case 6:
                            Console.WriteLine("Maio tem 31 dias");
                            break;
                        case 7:
                            Console.WriteLine("Junho tem 30 dias");
                            break;
                        case 8:
                            Console.WriteLine("Agosto tem 31 dias");
                            break;
                        case 9:
                            Console.WriteLine("Setembro tem 30 dias");
                            break;
                        case 10:
                            Console.WriteLine("Outubro tem 31 dias");
                            break;
                        case 11:
                            Console.WriteLine("Novembro tem 31 dias");
                            break;
                        case 12:
                            Console.WriteLine("Desembro tem 30 dias");
                            break;



                    }
                    break;
                   //---------------------------------------------------------------------------------------------------------------------
                case 4:
                    Console.WriteLine("exerciou 4 executando");
                    int N1;
                    int N2;
                    string OP;
                    Console.WriteLine("Digite um número");
                    N1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite outro número");
                    N2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual operação? +, -, /, *");
                    OP = Console.ReadLine(); switch (OP)
                    {
                        case "+":
                            res = N1 + N2;
                            Console.WriteLine("O Resultado é ", res);
                            break;
                        case "-":
                            res = N1 - N2;
                            Console.WriteLine("O Resultado é ", res);
                            break;
                        case "/":
                            res = N1 / N2;
                            Console.WriteLine("O Resultado é ", res); 
                            break;
                        case "*":
                            res = N1 * N2;
                            Console.WriteLine("O Resultado é ", res);
                            break;
                        case "^":
                            res = N1 ^ (N2);
                            Console.WriteLine("O Resultado é ", res); 
                            break;
                        default:
                            Console.WriteLine("Operação invalida");
                            break;
                    }

                            break;
                    //--------------------------------------------------------------------------------------------------------------------------------
                case 5:
                    Console.WriteLine("exerciou 4 executando");

                    break;
                case 6:
                    Console.WriteLine("exerciou 4 executando");
                    break;




            }
            Console.ReadKey();
        }
    }
}
