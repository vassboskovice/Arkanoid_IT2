using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Arkanoid_IT2
{
 public class Board : GameObject
 {
  public int Size { get; }

  public Board(int size)
  {
   Size = size;
  }

  public override void Draw(Canvas canvas)
  {
   Rectangle rectangle = new Rectangle();
   rectangle.Width = Size;
   rectangle.Height = 15;
   rectangle.Fill = Brushes.White;
   Canvas.SetBottom(rectangle, 20);
   Canvas.SetLeft(rectangle, Location.X - Size / 2);
   canvas.Children.Add(rectangle);
  }
 }
}
