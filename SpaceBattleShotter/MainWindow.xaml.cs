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
using System.Windows.Threading;

namespace SpaceBattleShotter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer gameTime = new DispatcherTimer();
        bool moveLeft, moveRight;
        List<Rectangle> itemRemover = new List<Rectangle>();

        Random rnd = new Random();

        int enemySpriterCounter = 0;
        int enemyCounter = 100;
        int playerSpeed = 10;
        int limit = 50;
        int score = 0;
        int demage = 0;
        int enemySpeed = 10;

        Rect playerHitBox;


        public MainWindow()
        {
            InitializeComponent();
            gameTime.Interval = TimeSpan.FromMilliseconds(20);
            gameTime.Tick += GameLoop;
            gameTime.Start();

            MyCanvas.Focus();

            // Cria um objeto do tipo ImageBrush e o nomeia como bg.
            ImageBrush bg = new ImageBrush();
            // Define a imagem de fundo do objeto bg como “purple.png” que está localizada na pasta “images” do aplicativo.
            bg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/purple.png"));
            // Define o modo de preenchimento da imagem de fundo como “Tile”.
            bg.TileMode = TileMode.Tile;
            //Define a área da imagem de fundo que será exibida no MyCanvas como um retângulo com as coordenadas (0, 0) e largura e altura de 0,15.
            bg.Viewport = new Rect(0, 0, 0.15, 0.15);
            //Define as unidades de medida para a área da imagem de fundo como relativas à caixa delimitadora do objeto MyCanvas.
            bg.ViewboxUnits = BrushMappingMode.RelativeToBoundingBox;
            //Define o objeto bg como o pano de fundo do objeto MyCanvas.
            MyCanvas.Background = bg;


            ImageBrush playerImage = new ImageBrush();
            playerImage.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/player.png"));
            player.Fill = playerImage;
        }

        private void GameLoop(object sender, EventArgs e)
        {
            
        }

        private void OnkeyDown(object sender, KeyEventArgs e)
        {

        }

        private void OnkeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
