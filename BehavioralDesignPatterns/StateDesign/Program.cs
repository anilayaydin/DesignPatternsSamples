using System;

namespace StateDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.x();
            game.triangle();
            game.square();
            game.lostBall();

            game.x();
            game.square();
            game.tackleBall();
        }
    }
}
