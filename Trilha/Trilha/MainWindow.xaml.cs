using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Trilha.Views;

namespace Trilha;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
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


    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NovoJogo_Click(object sender, RoutedEventArgs e)
    {
        var tabuleiroWindow = new GameTable(1,"",1,2,"",1);
        tabuleiroWindow.ShowDialog();
    }


    /// <summary>
    /// Método de ação responsável para que o usuário só consiga fechar a janela do jogo através desse botão
    /// </summary>
    private void SairBtn_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }


}

