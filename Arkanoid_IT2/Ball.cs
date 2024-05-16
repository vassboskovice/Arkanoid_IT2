using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Arkanoid_IT2
{
 public class Ball : GameObject
 {
  public double Size { get; set; }
  public Vector MoveVector { get; set; }

  public Ball(double size)
  {
   Size = size;
  }

  public override void Draw(Canvas canvas)
  {
   Ellipse ellipse = new Ellipse();
   ellipse.Width = Size;
   ellipse.Height = Size;
   ellipse.Fill = Brushes.White;
   Canvas.SetTop(ellipse, Location.Y - Size / 2);
   Canvas.SetLeft(ellipse, Location.X - Size / 2);
   canvas.Children.Add(ellipse);
  }

  public void Move(Rectangle rectangle)
  {
   Location = Point.Add(Location, MoveVector);
   if(Location.Y > rectangle.Height || Location.Y < 0)
   {
    MoveVector = new Vector(MoveVector.X, -MoveVector.Y);
   }
   if (Location.X > rectangle.Width || Location.X < 0)
   {
    MoveVector = new Vector(-MoveVector.X, MoveVector.Y);
   }
  }
 }
}
