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

namespace Arkanoid_IT2
{
 /// <summary>
 /// Interaction logic for MainWindow.xaml
 /// </summary>
 public partial class MainWindow : Window
 {
  private Game game;
  private DispatcherTimer timer;

  public MainWindow()
  {
   InitializeComponent();
  }

  private void MenuPrototype()
  {
   int w = 200;
   int h = 200;
   double menuX = (GameCanvas.ActualWidth - w) / 2;
   double menuY = (GameCanvas.ActualHeight - h) / 2;
   Rectangle menu = new Rectangle();
   menu.Width = w;
   menu.Height = h;
   menu.Fill = Brushes.White;
   Canvas.SetLeft(menu, menuX);
   Canvas.SetTop(menu, menuY);
   GameCanvas.Children.Add(menu);

   Rectangle item1 = new Rectangle();
   item1.Width = w * 0.8;
   item1.Height = h * 0.35;
   item1.Stroke = Brushes.Black;
   item1.Fill = Brushes.WhiteSmoke;
   Canvas.SetLeft(item1, menuX + w * 0.1);
   Canvas.SetTop(item1, menuY + h * 0.1);
   GameCanvas.Children.Add(item1);

   Rectangle item2 = new Rectangle();
   item2.Width = w * 0.8;
   item2.Height = h * 0.35;
   item2.Stroke = Brushes.Black;
   item2.Fill = Brushes.WhiteSmoke;
   Canvas.SetLeft(item2, menuX + w * 0.1);
   Canvas.SetTop(item2, menuY + h * 0.2 + item1.Height);
   GameCanvas.Children.Add(item2);
  }

  private void Window_Loaded(object sender, RoutedEventArgs e)
  {
   game = new Game();
   timer = new DispatcherTimer();
   timer.Interval = TimeSpan.FromMilliseconds(30);
   timer.Tick += Timer_Tick;
   timer.Start();
  }

  private void Timer_Tick(object? sender, EventArgs e)
  {
   GameCanvas.Children.Clear(); 
   game.Draw(GameCanvas);
  }

  private void GameCanvas_MouseMove(object sender, MouseEventArgs e)
  {
   game.SetBoardLocation(e.GetPosition(GameCanvas).X);
  }
 }
}
