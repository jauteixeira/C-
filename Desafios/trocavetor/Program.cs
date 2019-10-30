using System;

namespace trocavetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string [5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Nome: ");
                vetor[i] = Console.ReadLine();
            }
            
            System.Console.Write("troca :");
            string troca = Console.ReadLine();
            

            for(int y = 4; y >= 0; y--)
            {
                if(vetor [y] == troca)
                {
                Console.Write("Novo: ");
                vetor [y] = Console.ReadLine();
                break;
                }
                System.Console.WriteLine("Não encontrei o nome");
            }
        }
    }
}
