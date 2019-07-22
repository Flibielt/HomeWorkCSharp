using System.Windows;

using TableGame.ViewModel;
using TableGame.View;

namespace TableGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string PlayerName { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Game game = Game.GetGame();

            DataContext = this;
            string playerName = PlayerName;
            if (playerName.Length != 0)
            {
                game.Name = playerName;
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
                this.Close();
            }
        }
    }
}
