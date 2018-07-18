using System;
using ConsoleApp1;

namespace ConsoleApp1
{
     abstract public class Unit
    {

        public Unit(int x, int y, string UnitGraphic)
        {
            this.X = x;
            this.Y = y;
            this.unitGraphic = UnitGraphic; 



        }
        public int X
        {
            get
            {
                return _x;
            }
             set
            {
                if (value < 0 || value > Console.WindowWidth)
                {
                    throw new Exception("Invalid X position");

                }
              Undraw();
                _x = value;
            }
        }
        public int Y
        {

            get
            {
                return _y;
            }
            set
            {
                if ( value < 0 || value > Console.WindowHeight)
                {
                    throw new Exception("Invalid Y position");
                
                }
               Undraw();
                _y = value;
            }

        }


        private int _x;
        private int _y;

        private string unitGraphic;

       
        virtual public void update(int deltaTimeMs)
        {
            //We update, but i dont know how to do this .V



        }



        public void Draw()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.WriteLine(this.unitGraphic);
        }

        public void Undraw()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.WriteLine(' ');

        }
        
        public bool isCollided(Unit other)
        {
            if (this.X == other.X && this.Y == other.Y)
            {
                return true;
            }

            return false;

        }
        

    }
}
