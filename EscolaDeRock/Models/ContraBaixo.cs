using System;
using EscolaDeRock.Interface;


namespace EscolaDeRock.Models
{
    public class ContraBaixo : instrumentoMusical, IHarmonia, IPercurssao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do Baixo");
            return true;
        }
        
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do violão");
            return true;
        }
    }
}