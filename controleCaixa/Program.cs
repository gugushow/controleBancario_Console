using System;

namespace controleCaixa
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldo=0, valor;
            int opcao;


            Console.WriteLine("Fiab Bank\n\n");

            Console.WriteLine("Escolha uma das opções\n" +
                "1 Despósito \n" +
                "2 Saque \n" +
                "3 Consulta Saldo");
            opcao = Convert.ToInt32(Console.ReadLine());


            switch(opcao)
            {
                case 1:
                    {
                        Console.WriteLine("Digite o valor do depósito");
                        valor = Convert.ToDouble(Console.ReadLine());
                        saldo = saldo + valor;
                        Console.WriteLine("Depósito efetuado com sucesso!");
                        Console.WriteLine($"Saldo: R${saldo.ToString("0.00")}");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Digite o valor do saque");
                        valor = Convert.ToDouble(Console.ReadLine());
                        saldo = saldo - valor;
                        Console.WriteLine("Saque efetuado com sucesso!");
                        Console.WriteLine($"Saldo: R${saldo.ToString("0.00")}");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"Saldo: R${saldo.ToString("0.00")}");
                        break;
                    }
                default:
                        Console.WriteLine("Opção inválida");
                    break;
                    }
            }
        }
    }
