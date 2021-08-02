using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<10; i++)
            {
                Singleton singleton = Singleton.GetSingleton();
            }
           // Singleton singleton = Singleton.GetSingleton();
        }
    }
}
