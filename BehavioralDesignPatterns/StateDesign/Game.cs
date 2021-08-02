using System;

namespace  StateDesign
{
    public class Game
    {
        private Console console;
        public Game()
        {
            System.Console.WriteLine("Game was started...");
            console=new Attack();
        }
        public void triangle()
        {
            console.pressTriangle();
        }
        public void square()
        {
            console.pressSquare();
        }
        public void circle()
        {
            console.pressCircle();
        }
        public void x()
        {
            console.pressX();
        }
        public void tackleBall()
        {
            System.Console.WriteLine("The ball was taken and attacking.");
            console=new Attack();
        }

        public void lostBall()
        {
            System.Console.WriteLine("The ball was lost and defencing.");
            console=new Defence();
        }
        

    }

    
}