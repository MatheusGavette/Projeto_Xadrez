using Projeto_Xadrez.Tabuleiro_Camada;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Xadrez.Xadrez_Camada
{
    class Torre : Peca
    {
        public Torre (Cor cor, Tabuleiro tab) : base (cor, tab)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
