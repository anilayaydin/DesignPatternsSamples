using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("*******Using factory pattern:");
            PhoneSeller.getPhone();
            System.Console.WriteLine("*******Using abstract factory pattern:");
            PhoneSellerAbstract.getPhone();
        }
    }
}
