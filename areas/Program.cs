using System;

namespace areas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string a, b, c, d, e, f;
            double l1;
            double l2;
            double h;
            double r;
            double pi = 3.14;
            string x;


            do{



            Console.WriteLine("Escolha uma Opção");
            Console.WriteLine("Digite A para Quadrado");
            Console.WriteLine("Digite B para Triangulo");
            Console.WriteLine("Digite C para Circulo");
            Console.WriteLine("Digite D para Trapezio");
            Console.WriteLine("Digite E para Retangulo");
            Console.WriteLine("Digite F para Losango");
            Console.ReadLine();

            switch(x){
                case "a":
                    Console.Write("Diga o Lado: ");
                    l1=double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area: {l1} * {l1} = {l1*l1}");
                    break;
            
                case "b":
                    Console.Write("Diga a Base: ");
                    l1=double.Parse(Console.ReadLine());
                    Console.Write("Digite a Altura: ");
                    h=double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area: {l1} * {l1} /2 = {l1*l1/2}");
                    break;

                case "c":
                    Console.Write("Diga o pi: ");
                    pi=double.Parse(Console.ReadLine());
                    Console.Write("Diga o raio: ");
                    r=double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area: {pi} * {r} * {r} = ({pi*(r*r)}");
                    break;
                
                case "d":
                    Console.Write("Diga a base maior: ");
                    b1=double.Parse(Console.ReadLine());
                    Console.Write("Diga a base menor: ");
                    b2=double.Parse(Console.ReadLine());
                    Console.Write("Diga a altura: ");
                    h=double.Parse(Console.ReadLine());
                    Console.WriteLine($"Area: ({b1} + {b2}) * {h} / {2} = {(b1+b2) *h /2}");
                    break;



            }
        } while (x!="fim");
    }
}
}