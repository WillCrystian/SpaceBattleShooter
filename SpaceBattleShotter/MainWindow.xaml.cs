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

            ImageBrush bg = new ImageBrush();
            bg.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/purple.png"));
            bg.TileMode = TileMode.Tile;
            bg.Viewport = new Rect(0, 0, 0.15, 0.15);
            bg.ViewboxUnits = BrushMappingMode.RelativeToBoundingBox;
            MyCanvas.Background = bg;
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
