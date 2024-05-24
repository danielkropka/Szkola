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

namespace TicTacToeApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TicTacToe ttt;
        Button[] buttons;

        private void clearBoard()
        {
            foreach (Button button in buttons)
                button.Content = string.Empty;
        }

        public MainWindow()
        {
            InitializeComponent();
            ttt = new TicTacToe();
            buttons = new Button[] { Btn1, Btn2, Btn3, Btn4, Btn5, Btn6, Btn7, Btn8, Btn9 };
            foreach (Button button in buttons)
                button.Click += HandleButtonClick;
        }

        private void NewGameBtn_Click(object sender, RoutedEventArgs e)
        {
            clearBoard();
            ttt.StartGame();
            showCurrentPlayer();
            setStateButtons(true);
        }

        private void showCurrentPlayer() =>
            playerTB.Text = ttt.CurrentPlayer == Player.Circle ? "Kółko" : "Krzyżyk";

        private void CheckResult()
        {
            for (int i = 0; i < 3; i++)
                if (
                    ttt.Board[0, i] == ttt.CurrentPlayer
                    && ttt.Board[1, i] == ttt.CurrentPlayer
                    && ttt.Board[2, i] == ttt.CurrentPlayer
                )
                {
                    setStateButtons(false);
                    MessageBox.Show($"{ttt.CurrentPlayer} wygrał.");
                    return;
                }
                else if (
                    ttt.Board[i, 0] == ttt.CurrentPlayer
                    && ttt.Board[i, 1] == ttt.CurrentPlayer
                    && ttt.Board[i, 2] == ttt.CurrentPlayer
                )
                {
                    setStateButtons(false);
                    MessageBox.Show($"{ttt.CurrentPlayer} wygrał.");
                    return;
                }

            // [0, 0], [0, 1], [0, 2] == currentPlayer
        }

        private void setStateButtons(bool state)
        {
            foreach (var button in buttons)
                button.IsEnabled = state;
        }

        private void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            var row = Grid.GetRow(clickedButton);
            var col = Grid.GetColumn(clickedButton);
            if (ttt.Board[row, col] != Player.Nobody)
                return;
            clickedButton.Content = ttt.CurrentPlayer == Player.Circle ? "o" : "x";
            ttt.Board[row, col] = ttt.CurrentPlayer;
            CheckResult();
            ttt.NextPlayer();
            showCurrentPlayer();
        }
    }
}
