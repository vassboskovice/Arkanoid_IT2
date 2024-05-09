using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Arkanoid_IT2
{
 public class Game
 {
  private Board board;
  public List<GameObject> GameObjects { get; set; }

  public Game()
  {
   GameObjects = new List<GameObject>();
   CreateLevel(1);
  }

  public void CreateLevel(int level)
  {
   board = new Board(50);
   GameObjects.Add(board);
  }

  public void SetBoardLocation(double x)
  {
   board.Location = new Point(x, board.Location.Y);
  }

  public void Draw(Canvas canvas)
  {
   foreach (GameObject obj in GameObjects)
   {
    if (obj != null)
    {
     obj.Draw(canvas);
    }
   }
  }
 }
}
