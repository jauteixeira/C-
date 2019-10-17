using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
{
    public class Tambores : instrumentoMusical, IPercurssao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo dos Tambores");
            return true;
        }
    }
}