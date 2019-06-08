using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Xadrez.Tabuleiro_Camada
{
    class Tabuleiro
    {
        public int NumeroLinhas { get; set; }
        public int NumeroColunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int numeroLinhas, int numeroColunas)
        {
            NumeroLinhas = numeroLinhas;
            NumeroColunas = numeroColunas;
            Pecas = new Peca[NumeroLinhas, NumeroColunas];
        }

        public Peca RetornaPeca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca RetornaPeca(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return RetornaPeca(pos) != null;
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos)) 
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= NumeroLinhas || pos.Coluna < 0 || pos.Coluna >= NumeroColunas)
            {
                return false;
            }
            return true;
        }

        public void ValidarPosicao (Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida");
            }
        }
    }
}
