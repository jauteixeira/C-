using System;
using EscolaDeRock.Interface;


namespace EscolaDeRock.Models
{
    public class Bateria : instrumentoMusical, IPercurssao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo da Bateria.");
            return true;
        }
    }
}