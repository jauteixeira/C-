using System;
using System.IO;
using System.Collections.Generic;

namespace Senaizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunosTOTAL;


            int opcao;
            
            do{

            Console.Clear();
            System.Console.WriteLine("SEJA BEM VINDO AO PORTAL SENAI :)");
            
            System.Console.WriteLine("1 - Cadastrar Aluno");
            
            System.Console.WriteLine("2 - Cadastrar Sala");
            
            System.Console.WriteLine("3 - Alocar Aluno");
            
            System.Console.WriteLine("4 - Remover Aluno");
            
            System.Console.WriteLine("5 - Verificar Salas");
            
            System.Console.WriteLine("6 - Verificar Alunos");
            
            System.Console.WriteLine("0 - Sair");
            opcao = int.Parse(Console.ReadLine());
            
            switch(opcao)
            {
                case 1:
                    System.Console.WriteLine("Aluno cadastrado");
                    System.Console.WriteLine("Aperte enter pra continaur");
                    Alunos aluno1 = new Alunos("Joao", "Dev. Sistemas", 1);
                    Console.ReadLine();
                    break;
                
                case 2:
                    System.Console.WriteLine("Aluno cadastrado");
                    System.Console.WriteLine("Aperte enter pra continaur");
                    Salas sala1 = new Salas("Sala 1", "Dev. Sistemas", 1);
                    Console.ReadLine();
                    break;
            }
            } while (opcao !=0);
        }
    }
}
