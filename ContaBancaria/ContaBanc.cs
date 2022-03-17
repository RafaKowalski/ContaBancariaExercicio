using System;

namespace Curso
{
     class ContaBanc
    {
        public int NumeroDaConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBanc(int numeroDaConta, string nomeTitular)
        {
            NumeroDaConta = numeroDaConta;
            NomeTitular = nomeTitular;
        }

        public ContaBanc(int NumeroDaConta, string nomeTitular, double depositoInicial) : this (NumeroDaConta, nomeTitular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito (double saldo)
        {
            Saldo = Saldo + saldo;
        }

        public void Saque (double saldo)
        {
           Saldo = Saldo - 5 - saldo;
        }

        public override string ToString()
        {
            return
                "\nConta: " 
                + NumeroDaConta 
                + ", Titular: " 
                + NomeTitular 
                + ", Saldo: $ " 
                + Saldo;
        }

    }
}
