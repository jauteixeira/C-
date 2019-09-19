using System;

namespace media
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;
            double media;


            Console.WriteLine("digite a 1° nota");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a 2° nota");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a 3° nota");
            num3 = int.Parse(Console.ReadLine());
            
            
            media = (num1 + num2 + num3) / 3;
            Console.WriteLine($"media: {+media}");

            if (media >= 7) {
            Console.WriteLine("Aprovado");
            }

            else{
                Console.WriteLine("Reprovado");
            }

        }
    }
}