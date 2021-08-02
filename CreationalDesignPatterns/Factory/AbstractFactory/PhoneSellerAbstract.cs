using System;

namespace Factory
{
    class PhoneSellerAbstract
    {
        public static void getPhone()
        {
            S8Factory s8Factory = new S8Factory();
            Phone s8=s8Factory.GetPhone("s8","2600mah",4,7);
            Note8Factory note8Factory = new Note8Factory();
            Phone note8=note8Factory.GetPhone("note8","3000mah",5,8);

            System.Console.WriteLine(s8);
            System.Console.WriteLine(note8);
        }
    }
}