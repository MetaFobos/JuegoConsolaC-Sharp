using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PlayerUnit : Unit
    {
        public PlayerUnit(int x, int y, string UnitGraphic) : base(x, y, UnitGraphic)
        {
        }

        override public void update(int DeltaTimeMs)
        {

            if (Console.KeyAvailable == true)
            {

                ConsoleKeyInfo ckei = Console.ReadKey(true);

                switch (ckei.Key)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if(Y > 0)
                        {
                            Y--;
                        }
                       
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if(Y < Console.WindowHeight-1)
                        {
                            Y++;
                        }
                        
                        break;
                  




        

                }



            }


            base.update(DeltaTimeMs);
        }

    }
}
