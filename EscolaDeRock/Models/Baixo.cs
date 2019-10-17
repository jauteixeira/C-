using System;
using EscolaDeRock.Interface;


namespace EscolaDeRock.Models
{
    public class Baixo : instrumentoMusical, IPercurssao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do Baixo");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Baixo");
            return true;
        }
    }
}