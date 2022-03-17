using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanc b;

            Console.WriteLine("entre o número da conta: ");
            int NumeroDaConta = int.Parse(Console.ReadLine());

            Console.WriteLine("entre o titular da conta: ");
            string NomeTitular = Console.ReadLine();

            Console.WriteLine("haverá depósito inicial (s/n)? ");
            string resposta = Console.ReadLine();
            if (resposta == "s" )
            {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                 b = new ContaBanc(NumeroDaConta, NomeTitular, depositoInicial);
            }
            else
            {
                b = new ContaBanc(NumeroDaConta, NomeTitular);
            }
            
            Console.WriteLine("Dados da conta: " + b);

            Console.WriteLine("\nEntre um valor para depósito: ");
            double saldo = double.Parse(Console.ReadLine());
            b.Deposito(saldo);
            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(b);

            Console.WriteLine("Entre um valor para Saque: ");
            saldo = double.Parse(Console.ReadLine());
            b.Saque(saldo);
            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(b);
        }
    }
}