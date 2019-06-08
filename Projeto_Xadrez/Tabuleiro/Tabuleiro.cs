using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Xadrez.Tabuleiro
{
    class Tabuleiro
    {
        public int NumeroLinhas { get; set; }
        public int NumeroColunas { get; set; }
        private Peca[,] Pecas { get; set; }

        public Tabuleiro(int numeroLinhas, int numeroColunas)
        {
            NumeroLinhas = numeroLinhas;
            NumeroColunas = numeroColunas;
            Pecas = new Peca[NumeroLinhas, NumeroColunas];
        }
    }
}
