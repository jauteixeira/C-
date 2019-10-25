using System;
using System.Collections.Generic;
using System.Text;

namespace trianguloinverso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o tamanho");
            try
            {
                int nivel = int.Parse(Console.ReadLine());
                if (nivel != 0)
                {

                    int a;
                    int espacos;
                    for (int i = nivel; i >= 1; i--)
                    {
                        StringBuilder final = new StringBuilder();

                        espacos = nivel - i;
                        a = i + (i - 1);
                        for (int i1 = 0; i1 < espacos; i1++)
                            final.Append(" ");

                        for (int i2 = 0; i2 < a; i2++)
                            final.Append("*");

                        Console.WriteLine(final.ToString());
                    }
                }
                else
                {
                    System.Console.Clear();
                }
            }
            catch (Exception )
            {
                System.Console.Clear();
            }
        }
    }
}