using System;
namespace StateDesign
{
    public class Defence:Console
    {
        public void pressSquare()
        {
            System.Console.WriteLine("Intervention");
        }

        public void pressCircle()
        {
            System.Console.WriteLine("Middle opening");
        }
        public void pressTriangle()
        {
            System.Console.WriteLine("Goalkeeper");
        }
        public void pressX()
        {
            System.Console.WriteLine("Make pressure");
        }

        
    }
}