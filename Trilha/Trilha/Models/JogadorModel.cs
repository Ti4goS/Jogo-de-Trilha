﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trilha.Model;
///<Summary>
///A Classe jogador define o modelo de um jogador para que, 
///caso seja vitorioso seu nome seja guardado em um arquivo
///onde mostra seu nome + numero de vitórias
///<list type="bullet">
///<item>Nome: Nome do Jogador</item>
///<item>numeroVitorias: Numero de vitórias que o jogador possui</item>
///<item>quantidadePecas: Quantidade de Peças Atual do Jogador (Padrão é 9)</item>
///<item>cor: Cor para identificar qual dos 2 jogadores o objeto é</item>
/// </list>
/// </Summary>
/// 
public class JogadorModel
{
    private int Id { get; set; }
    public String Nome { get; set; }
    public int NumeroVitorias { get; set; }
    public int QuantidadePecas { get; set; }
    public CorJogador Cor { get; set; }

    public JogadorModel(int id, string nome, int numeroVitorias, int quantidadePecas, CorJogador cor)
    {
        Id = id;
        Nome = nome;
        NumeroVitorias = numeroVitorias;
        QuantidadePecas = quantidadePecas;
        Cor = cor;
    }
}


