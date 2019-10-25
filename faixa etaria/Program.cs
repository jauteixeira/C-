using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoAtual= 2019;
            int anoNasc= 0;
            int idade;
            
            
            Console.WriteLine("Qual é o seu ano de nascimento ?: ");
            anoNasc = int.Parse(Console.ReadLine());
            idade = anoAtual - anoNasc;

            Console.WriteLine("Sua idade atual é de " + idade + " anos ");


        if (idade <=2)
        {
            Console.WriteLine("Classificado como Recém-Nascido");
        }

        else if ((idade >=3) && (idade <=11)) 
        {
            Console.WriteLine("Classificado como Criança");
        }
        else if ((idade >=12) && (idade <=19)) 
        {
            Console.WriteLine("Classificado como Adolescente");
        }

        else if ((idade >=20) && (idade <65)) 
        {
            Console.WriteLine("Classificado como Adulto");
        }

        else if (idade >=65) 
        {
            Console.WriteLine("Classificado como Idoso");

        }

        }
    }
}
