using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace BreakoutGame
{
    class Game
    {
        //Timer
        private DispatcherTimer timer;

        //Canvas
        private Canvas canvas;
       
        //Ball
        private Ball ball;

        //Paddle
        public Paddle paddle;

        private List<Block> blocks;
        //Constructor
        public Game(Canvas canvas)
        {
            this.canvas = canvas;

            CreateBall();
            CreatePaddle();
            CreateBlocks();
            IsGameOver();
        }
        //Game Over
        private void IsGameOver()
        {
            //All blocks removed
            if (blocks.Count == 0)
            {
                Debug.WriteLine("Game Over - Great job!");
                timer.Stop();
            }
            //Ball below paddle
            if(ball.LocationY > paddle.LocationY)
            {
                Debug.WriteLine("Game over - You suck");
                timer.Stop();
            }
        }
        
        
        
        //Add ball to game
        private void CreateBall()
        {
            ball = new Ball
            {
                LocationX = 390,
                LocationY = 500
            };
            canvas.Children.Add(ball);
        }        
        //Create Paddle and add to Canvas
        private void CreatePaddle()
        {
            paddle = new Paddle
            {
                LocationX = 350,
                LocationY = 550
            };
            canvas.Children.Add(paddle);
        }

        //Create Blocks
        private void CreateBlocks()
        {
            blocks = new List<Block>();
            int blocksCount = 120;
            int cols = 12; // 12 columns
            int xStartPos = 70;
            int yStartPos = 30;
            int step = 5;
            int row = 0;    //rows 
            int col = 0;    //columns

            for (int i = 0; i < blocksCount; i++)
            {
                //Is it a new row
                if (i % cols == 0 && i > 0)
                {
                    row++; //new row
                    col = 0;
                }

                else if (i > 0)
                {
                    col++;
                }
                //Block position
                int x = (50 + step) * col + xStartPos; //0, 55, 110, 165, ...
                int y = (20 + step) * row + yStartPos; //0, 25, 50, 75, ...
                //Create a Block
                Block block = new Block
                {
                    LocationX = x,
                    LocationY = y
                };
                //Add to blocks
                blocks.Add(block); //List collection
                //Add to canvas
                canvas.Children.Add(block);
                //Set Location in Canvas
                block.SetLocation();
            }
         }

        //Start game
        public void StartGame()
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / 60); //60FPS
            timer.Start();
        }
        //Game Loop
        private void Timer_Tick(object sender, object e)
        {
            ball.Move();
            CheckCollision();
        }
        private void CheckCollision()
        {
            //Ball and paddle
            Rect r1 = ball.GetRect();
            r1.Intersect(paddle.GetRect());
            if (!r1.IsEmpty)
            {
                //Paddle 100px
                //Ball position 0-100
                double ballPosition = ball.LocationX - paddle.LocationX;
                //-0.5 <-> 0.5
                double hitPercent = (ballPosition / paddle.Width) - 0.5;
                //set ball speed
                ball.SetSpeed(hitPercent);
            }
            
            //Ball and blocks
            foreach(Block block in blocks)
            {
                Rect ballRect = ball.GetRect();
                ballRect.Intersect(block.GetRect());
                if(!ballRect.IsEmpty)
                {
                    //Remove from list
                    blocks.Remove(block);
                    //Remove from canvas
                    canvas.Children.Remove(block);
                    //Ball SpeedX and SpeedY?
                    double ballCenter = ball.LocationX + (ball.Width) / 2;
                    if (ballCenter < block.LocationX || ballCenter > (block.LocationX + block.Width))
                    {
                        ball.SpeedX *= -1;
                    } else
                    {
                        ball.SpeedY *= -1;
                    }
                    break;
                }
            }

        }
    }
}
