using System;

namespace Factory
{
    class PhoneSeller
    {
        public static void getPhone()
        {
            Phone s8 = PhoneFactory.GetPhone("s8","2600mah",4,7);
            Phone note8 = PhoneFactory.GetPhone("note8","3000mah",5,8);
            
            System.Console.WriteLine("Phone properties for S8");
            System.Console.WriteLine(s8);
            System.Console.WriteLine("Phone properties for Note8");
            System.Console.WriteLine(note8);
        }
    }
}