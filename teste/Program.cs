using System;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int val=15;  
            int i, j, k ;  



            Console.Write("Diga a Altura");
            Console.ReadLine();
            Console.Write("Diga a Quantidade");
            Console.ReadLine();


                 
         for (i = 1; i <= val; i++)  
         {  
            for (j = 1; j <= val-i; j++)  
            {  
               Console.Write(" ");  
            }  
            for (k = 1; k <= i; k++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }    
      }  
   }  
} 
