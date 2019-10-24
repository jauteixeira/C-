using System;
using EscolaDeRock.Interface;


namespace EscolaDeRock.Models
{
    public class Bateria : instrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo da Bateria.");
            return true;
        }
    }
}