using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EnemyUnit : Unit
    {
        public EnemyUnit(int x, int y, string unitGraphic) : base(x, y, unitGraphic)
        {

        }

        
        public int TimeBetweenMoves = 30;
        private int timeSinceTheLastMove = 0;
        bool OneRound = true;
        

        override public void update(int deltaTimeMs)
        {
            timeSinceTheLastMove += deltaTimeMs;

            if(TimeBetweenMoves > timeSinceTheLastMove)
            {
                return;
            }

            timeSinceTheLastMove -= TimeBetweenMoves;


            if (X > 0 && OneRound)
            {
                X = X - 1;

            }
            else if ( X < Console.WindowWidth-1)
            {
                
                
                OneRound = false;
                X = X + 1;
            }
            else
            {
                OneRound = true;
                Game.Score++;
              
                Y = Game.rand.Next(1, Console.WindowHeight - 3);
               
                if ( TimeBetweenMoves > 10)
                {
                    TimeBetweenMoves = TimeBetweenMoves * 90 / 100;
                    
                }
                
            }
            
           

            base.update(deltaTimeMs);
        }

    }
}
