using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Arkanoid_IT2
{
 public class Game
 {
  //private Timer timerEngine;

  private Board board;
  private Ball ball;
  public List<GameObject> GameObjects { get; set; }

  public Game()
  {
   //timerEngine = new Timer();
   //timerEngine.Interval = 20;
   //timerEngine.Elapsed += TimerEngine_Elapsed;
   GameObjects = new List<GameObject>();
   CreateLevel(1);
  }

  //private void TimerEngine_Elapsed(object? sender, ElapsedEventArgs e)
  //{
  // ball.Move();
  //}

  public void CreateLevel(int level)
  {
   board = new Board(100);
   ball = new Ball(20);
   ball.Location = new Point(100, 100);
   ball.MoveVector = new Vector(5,5);
   GameObjects.Add(board);
   GameObjects.Add(ball);
   //timerEngine.Start();
  }

  public void SetBoardLocation(double x)
  {
   board.Location = new Point(x, board.Location.Y);
  }

  public void Move(Rectangle rectangle)
  {
   ball.Move(rectangle);
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
