using System;
using ByteBank2.Models;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string cliente1 = "Rubens";
            string cliente2 = "Astoufo";

            ContaCorrente contaCorrente1 = new ContaCorrente (1, 1, cliente1);
            ContaCorrente contaCorrente2= new ContaCorrente (1, 1, cliente2);
            DepositarConta(contaCorrente1);
            DepositarConta(contaCorrente2);
            SacarConta(contaCorrente1);
            SacarConta(contaCorrente2);
            TransferirEntreContas(contaCorrente1, contaCorrente2);
        }

            public static void DepositarConta (ContaBancaria contaBancaria)
            {            
            Console.WriteLine("ByteBank - Deposito");
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine();
            string usuario = contaBancaria.Titular;
            Console.WriteLine($"Bem vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
            Console.Write("Digite o valor do Deposito: ");
            double valor = double.Parse(Console.ReadLine());
            saldo = contaCorrente.Deposito(valor);
            Console.WriteLine($"Saldo atual: {saldo}");
            Console.WriteLine();

            Console.WriteLine("ByteBank - Saque");
            Console.WriteLine($"Bem vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia: {contaCorrente.Agencia}   Conta: {contaCorrente.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
            Console.Write("Qual o valor do Saque? ");
            valor = double.Parse(Console.ReadLine());
            }
    }
}
