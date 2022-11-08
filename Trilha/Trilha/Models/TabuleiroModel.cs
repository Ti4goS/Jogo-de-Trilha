using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trilha.Model;

namespace Trilha.Models;

public class TabuleiroModel
{
    private readonly CorJogador[] Tabuleiro = new CorJogador[24];


    /// <summary>
    /// Inicializa o tabuleiro com todas as posições vazias
    /// </summary>
    public TabuleiroModel()
    {
        for (int i = 0; i < Tabuleiro.Length; i++) Tabuleiro[i] = CorJogador.Empty;
    }


    /// <summary>
    /// Posiciona a peça no tabuleiro
    /// </summary>
    /// <param name="cor">Indica a cor do jogador</param>
    /// <param name="posicao">Posição do vetor que a peça deve ser posicionada</param>
    /// <returns>Retorna a Cor do jogador que realizará a próxima jogada</returns>
    public CorJogador PosicionaPeca(CorJogador cor, int posicao)
    {
        if (Tabuleiro[posicao].Equals(CorJogador.Empty))
        {
            Tabuleiro[posicao] = cor;
            return cor.Equals(CorJogador.Azul) ? CorJogador.Vermelho : CorJogador.Azul;
        }

        return cor;
    }


    /// <summary>
    /// Movimenta uma peça do tabuleiro
    /// </summary>
    /// <param name="cor">Indica a cor do jogador</param>
    /// <param name="origem">Posição de origem do vetor que a peça deve ser Movida</param>
    /// <param name="destino">Posição de Destino do vetor que a peça deve ser Posicionada</param>
    /// <returns>Retorna a Cor do jogador que realizará a próxima jogada</returns>
    public CorJogador MovimentaPeca(CorJogador cor, int origem, int destino)
    {
        if (Tabuleiro[origem].Equals(cor) && Tabuleiro[destino].Equals(CorJogador.Empty))
        {
            Tabuleiro[destino] = cor;
            Tabuleiro[origem] = CorJogador.Empty;
            return cor.Equals(CorJogador.Azul) ? CorJogador.Vermelho : CorJogador.Azul;
        }

        return cor;
    }
}

