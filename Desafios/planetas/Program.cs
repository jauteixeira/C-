using System;

namespace planetas
{
    class Program
    {
        static void Main(string[] args)
        {

            int planeta;
            int peso;

            System.Console.WriteLine("********************PLANETAS********************");
            System.Console.Write("Digite seu peso: ");
            peso = int.Parse(Console.ReadLine());
            System.Console.WriteLine("1- MERCURIO");
            System.Console.WriteLine("2- VENUS");
            System.Console.WriteLine("3- MARTE");
            System.Console.WriteLine("4- JUPITER");
            System.Console.WriteLine("5- SATURNO");
            System.Console.WriteLine("6- URANO");
            planeta = int.Parse(Console.ReadLine());
            
            switch (planeta)
            {
                case 1 :
                System.Console.WriteLine("MERCURIO");
                System.Console.WriteLine($"{(peso/10)*0.37}");
                break;

                case 2 :
                System.Console.WriteLine("VENUS");
                System.Console.WriteLine($"{(peso/10)*0.88}");
                break;

                case 3 :
                System.Console.WriteLine("MARTE");
                System.Console.WriteLine($"{(peso/10)*0.38}");
                break;

                case 4 :
                System.Console.WriteLine("JUPITER");
                System.Console.WriteLine($"{(peso/10)*2.64}");
                break;

                case 5 :
                System.Console.WriteLine("SATURNO");
                System.Console.WriteLine($"{(peso/10)*1.15}");
                break;

                case 6 :
                System.Console.WriteLine("URANO");
                System.Console.WriteLine($"{(peso/10)*1.17}");
                break;
            
            default:
            System.Console.WriteLine("INVALIDO");
            break;
            }
        }
    }
}
