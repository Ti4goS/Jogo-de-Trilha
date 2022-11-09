using System;
using System.Runtime.ConstrainedExecution;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Trilha.Controllers;
using Trilha.Model;
using Trilha.Models;

namespace Trilha.Views;

/// <summary>
/// Lógica interna para GameTable.xaml
/// </summary>
public partial class GameTable : Window
{
    private readonly JogoController jogoController;
    private CorJogador JogadorAtual;
    private CorJogador Proximojogador;
    private int PecaOrigem = 0;
    private int PecaDestino = 0;

    public GameTable(int idVermehlo, String nomeVermelho, int vitoriasVermelho, int idAzul, String nomeAzul, int vitoriasAzul)
    {
        jogoController = new JogoController(idVermehlo, nomeVermelho, vitoriasVermelho, idAzul, nomeAzul, vitoriasAzul);

        JogadorAtual = CorJogador.Vermelho;
        Proximojogador = CorJogador.Empty;

        InitializeComponent();
    }


    /// <summary>
    /// Método responsável por deixar com que o usuário movimente a janela livremente com o botão esquerdo do mouse
    /// </summary>
    private void MoveWindow(object sender, MouseButtonEventArgs e)
    {
        if (e.ChangedButton == MouseButton.Left)
            this.DragMove();
    }


    private void SelectPecas1_Click(object sender, RoutedEventArgs e) => RealizaAcao(1, Peca1);



    private void SelectPecas2_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(2, Peca2);
    }

    private void SelectPecas3_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(3, Peca3);
    }

    private void SelectPecas4_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(4, Peca4);
    }

    private void SelectPecas5_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(5, Peca5);
    }

    private void SelectPecas6_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(6, Peca6);
    }

    private void SelectPecas7_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(7, Peca7);
    }

    private void SelectPecas8_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(8, Peca8);
    }

    private void SelectPecas9_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(9, Peca9);
    }

    private void SelectPecas10_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(10, Peca10);
    }

    private void SelectPecas11_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(11, Peca11);
    }

    private void SelectPecas12_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(12, Peca12);
    }

    private void SelectPecas13_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(13, Peca13);
    }

    private void SelectPecas14_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(14, Peca14);
    }

    private void SelectPecas15_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(15, Peca15);
    }

    private void SelectPecas16_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(16, Peca16);
    }

    private void SelectPecas17_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(17, Peca17);
    }

    private void SelectPecas18_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(18, Peca18);
    }

    private void SelectPecas19_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(19, Peca19);
    }

    private void SelectPecas20_Click(object sender, RoutedEventArgs e)
    {
        RealizaAcao(20,Peca20);


    }



    private void Button_Click(object sender, RoutedEventArgs e)
    {
        
    }

    private void RealizaAcao(int peca, Button btn)
    {
        if (jogoController.AindaPosiciona(JogadorAtual))
        {
            Proximojogador = jogoController.Jogar(JogadorAtual, peca);

            if (TabuleiroModel.NotEquals(JogadorAtual, Proximojogador))
                btn.Background = jogoController.PintaBotao(JogadorAtual);

            PassaRodada();
        }
        else
        {
            if(PecaOrigem==0 && PecaDestino == 0)
            {
                PecaOrigem = peca;
                btn.Background = Brushes.Black;
            }

            else if (PecaOrigem != 0 && PecaDestino == 0)
            {
                //TODO 
            }
        }
    }

    private void PassaRodada()
    {
        JogadorAtual = Proximojogador;
        Proximojogador = CorJogador.Empty;
    }
}

