using System;


namespace EscolaDeRock.Models
{
    public class instrumentoMusical
    {
        string [] notas = {"Do", "Re", "Mi", "Fa", "Sol", "La", "Si"};
        
        public string TocarMusica()
        {
            int nota = new Random ().Next (notas.Length - 1);
            return notas [nota];
        }
    }
}