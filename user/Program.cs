using System;

namespace user
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string senha;


            Console.WriteLine("USERNAME ");
            login=(Console.ReadLine());
            Console.WriteLine("SENHA ");
            senha=(Console.ReadLine());

            if((login == "admin") && (senha == "admin")) {
                Console.WriteLine("Seja Bem Vindo Administrador !");
            }
            
            else
            {
                Console.WriteLine("Seja Bem Vindo Usuário");
            }

        }
    }
}
