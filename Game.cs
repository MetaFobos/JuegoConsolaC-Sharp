using System;
using ConsoleApp1;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Game
    {
        
        public Game()
        {
            Console.CursorVisible = false;
            player = new PlayerUnit(Console.WindowWidth/2, Console.WindowHeight/2, "X");
            MaluloUnits = new EnemyUnit[10];
            rand = new Random();
            Score = 0;

            for (int i = 0; i < numUnits; i++)
            {

                MaluloUnits[i] = new EnemyUnit(Console.WindowWidth - 1, rand.Next(0, Console.WindowHeight - 1), "@");
            }


            stopwatch = new Stopwatch();
        }
        
        private Unit player;
        private Unit[] MaluloUnits;
        private Stopwatch stopwatch;
        public static Random rand;
        private int numUnits = 8;
        public static int Score;


        public void Start()
        {
            stopwatch.Start();
            long timeAtPreviusFrame = stopwatch.ElapsedMilliseconds;
            int DeltaTimeMs;


            while (true)
            {
                DeltaTimeMs = (int)(stopwatch.ElapsedMilliseconds - timeAtPreviusFrame);
                timeAtPreviusFrame = stopwatch.ElapsedMilliseconds;

                //First we update the position
                
                player.update(DeltaTimeMs);
                for(int i = 0; i < numUnits; i++)
                {
                    MaluloUnits[i].update(DeltaTimeMs);
                    if (player.isCollided(MaluloUnits[i]))
                    {
                        GameOver();
                        return;
                    }
                }

           
          
                //Then we draw in the position
                for( int i = 0; i <numUnits;i++)
                {
                    MaluloUnits[i].Draw();
                }
                player.Draw();
                //Malulo.Draw();

                //Draw the score:
                DrawScore();

                Thread.Sleep(5);
            }
        }
        
        public void GameOver()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine("GAME OVER !");

        }
        public void DrawScore()
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.WriteLine("SCORE :  " + Score);
        }
        
     

    }
}
