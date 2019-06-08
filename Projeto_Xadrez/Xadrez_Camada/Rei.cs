using Projeto_Xadrez.Tabuleiro_Camada;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Xadrez.Xadrez_Camada
{
    class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
