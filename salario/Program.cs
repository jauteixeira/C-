using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double pay;
            double aumento;
            
            Console.Write("Digite seu Salário: ");
            pay = double.Parse(Console.ReadLine());


            if (pay < 500){
                aumento = pay *0.3;
                pay += aumento;
                Console.WriteLine("Parabens, voce ganhou um aumento");
                Console.WriteLine($"Seu novo salario: R$ {pay:F2}");
            }

            else{
                Console.WriteLine("Desculpe, sem aumento de salario para você");
            }
        }
    }
}
