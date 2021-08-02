using System;

namespace StateDesign
{
    public class Attack:Console
    {
        public void pressSquare()
        {
            System.Console.WriteLine("Shooting");
        }

        public void pressCircle()
        {
            System.Console.WriteLine("Middle opening");
        }
        public void pressTriangle()
        {
            System.Console.WriteLine("Passing");
        }
        public void pressX()
        {
            System.Console.WriteLine("Challenging");
        }
    }
    
}