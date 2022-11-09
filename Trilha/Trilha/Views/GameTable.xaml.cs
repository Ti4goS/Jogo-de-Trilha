using System;
using System.Windows;
using System.Windows.Input;
using Trilha.Controllers;
using Trilha.Model;

namespace Trilha.Views;

/// <summary>
/// Lógica interna para GameTable.xaml
/// </summary>
public partial class GameTable : Window
{
    private readonly JogoController jogoController;
    private CorJogador JogadorAtual;
    private CorJogador Proximojogador;

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

    private void SelectPecas1_Click(object sender, RoutedEventArgs e)
    {
        Proximojogador = jogoController.Jogar(JogadorAtual, 1);
        Peca1.Background = jogoController.PintaBotao(JogadorAtual);
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {

    }
}

