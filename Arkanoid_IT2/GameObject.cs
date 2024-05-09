using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Arkanoid_IT2
{
 public abstract class GameObject
 {
  public Point Location { get; set; }

  public abstract void Draw(Canvas canvas);
 }
}
