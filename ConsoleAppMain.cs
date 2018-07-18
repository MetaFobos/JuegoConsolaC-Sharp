using ConsoleApp1;
using System;

namespace practicePrograma
{
    class MainGameClass
    {
        static void Main() {

            Game ourGame = new Game();

            ourGame.Start();
 

            //Debug Line
            Console.SetCursorPosition(0, Console.WindowHeight-1);
            Console.WriteLine("Please any key to continue");
            Console.ReadKey();
        


        }






    }






}