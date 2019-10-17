using System;
using EscolaDeRock.Models;
using EscolaDeRock.Interface;

namespace EscolaDeRock
{
    enum FormaçaoEnun : uint
    {
        TRIO = 3,
        QUARTETO
    };

    enum InstrumentosEnun : uint
    {
        BAIXO,
        
        CONTRABAIXO,
        
        GUITARRA,
        
        BATERIA,

        TECLADO,

        TAMBORES,

    };

    enum CategoriaEnun : uint
    {
        HARMONIA,

        PERCURSSAO,

        MELODIA
    };
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            string [] itensMenuPrincipal = Enum.GetNames(typeof(FormaçaoEnum));
            string [] itensMenuCategoria = Enum.GetNames(typeof(FormaçaoEnum));

            var opcoesFormacao = new List <string> ()
            {
                "    -0                  ",
                "    -1                  "
            };

            int opcoesFormacaoSelecionada = 0;
            string menubar = "=======================================";


            do
            {
                bool formacaoEscolhida = false;
                do
                {
                    Console.Clear();
                    System.Console.WriteLine(menubar);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine(" Seja Bem-Vindo ");
                    System.Console.WriteLine(" Escolhe uma Formação ");
                    Console.ResetColor();
                    System.Console.WriteLine(menubar);

                    for(int i = 0; i < opcoesFormacao.Count; i++)
                    {
                        string titulo = TratarTituloMenu(itensMenuPrincipal[1]);
                        if(opcoesFormacaoSelecionada == i)
                        {
                            DestacarOpcao(opcoesFormacao[opcoesFormacaoSelecionada].Replace("-", ">").Replace(i.));
                        }

                        else
                        {
                            System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(),titulo));
                        }

                        var key = Console.ReadLine(true).Key;

                        switch (key)
                        {
                            case ConsoleKey.UpArrow: 
                                opcoesFormacaoSelecionada = opcoesformacaoselecionada == 0 ? opcoesFormacaoSelecionada
                        }                        
                    }
                }
            }
        }
    }
}
