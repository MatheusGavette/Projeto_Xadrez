using System;
using Projeto_Xadrez.Tabuleiro_Camada;
using Projeto_Xadrez.Xadrez_Camada;
using System.Globalization;
using System.Collections.Generic;

namespace Projeto_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 6));
                tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 2));

                tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(0, 1));
                tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(1, 7));
                tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(2, 3));


                Tela.ImprimirTabuleiro(tab);

                Console.WriteLine();
            }
            catch (TabuleiroException e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
