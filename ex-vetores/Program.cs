using System;

namespace ex_vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetor = new int [6];
            string a;

            Console.Write("digite um numero " );
            Console.ReadLine();
            
            for (int i = 0; i < a.Length; i++) 
        {
            a[i] = i * i;
        }
        for (int i = 0; i < a.Length; i++) 
        {
            Console.WriteLine($"a[{i}] = {a[i]}");

        }
    }
}
}
