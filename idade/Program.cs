using System;

namespace idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int age1 = 0;



            Console.WriteLine("Digite sua Idade");
            age1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Mês: {age1}*{12} = {age1 * 12}");
            Console.WriteLine($"Dia: {age1}*{365} = {age1 * 365}");
            Console.WriteLine($"Horas: {age1}*{8760} = {age1 * 8760}");
            Console.WriteLine($"Minutos: {age1}*{525600} = {age1 * 525600}");
        }
    }
}
