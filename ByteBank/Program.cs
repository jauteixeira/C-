using System;
using ByteBank.Models;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Cadastro de Cliente");
            System.Console.WriteLine();
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("E-mail: ");
            string email= Console.ReadLine();
            System.Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            
            Cliente cliente1 = new Cliente(nome, email, cpf);

            bool trocouSenha = false; 
            do{
                System.Console.Write("Digite a Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = cliente1.TrocarSenha (senha);

                if (!trocouSenha){
                    System.Console.WriteLine("Senha não atende aos requisitos");
                }
                else{
                    System.Console.WriteLine("Senha trocada com sucesso");
                }
            }while(!trocouSenha);

            System.Console.WriteLine("Cadastro de Conta Corrente");
            System.Console.WriteLine();
            System.Console.Write("Nome do Titular: ");
            string titular = Console.ReadLine();
            System.Console.Write("Agencia: ");
            int agencia= int.Parse(Console.ReadLine());
            System.Console.Write("Numero da Conta: ");
            int numeroc = int.Parse(Console.ReadLine());

            bool saldovalido = false;

            do{
                System.Console.Write("Seu Saldo: ");
                double saldo = double.Parse(Console.ReadLine());

                if (saldo >= 0){
                    saldovalido = true;
                }
                else{
                    System.Console.WriteLine("O saldo não pode ser negativo");
                }
            }while(!saldovalido);

            ContaCorrente contaCorrente = new ContaCorrente (agencia,numeroc,titular);
        }
    }
}