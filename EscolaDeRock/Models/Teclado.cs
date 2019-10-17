using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
{
    public class Teclado
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do violão");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando sala do Violão");
            return true;
        }
    }
}