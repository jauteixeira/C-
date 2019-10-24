using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius, faren;
            Console.WriteLine("Digite a Temperatura(°C) : ");
            celsius = int.Parse(Console.ReadLine());
            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("A Temperatura em Fahrenheit(°F) : " + faren);
        }
    }
}