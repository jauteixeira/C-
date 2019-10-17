using System;
using EscolaDeRock.Interface;
using EscolaDeRock.Models;

namespace EscolaDeRock.Interface
{
    public class Violao : instrumentoMusical, IHarmonia, IMelodia, IPercurssao
    
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

        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do Violão");
            return true;
        }
    }
}