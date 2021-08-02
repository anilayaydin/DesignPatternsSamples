using System;
namespace Singleton
{
    class Singleton
    {
        private static Singleton singleton;
        private static object locked = new object();
        private static int sayi = 0;
        private Singleton()
        {
            System.Console.WriteLine("Instance created.");
        }

        public static Singleton GetSingleton()
        {
            if(singleton == null) {
                lock(locked) // Multithread ise uygulama birden fazla istek gelecek ve birden fazla nesne oluşturmaya çalışacak. Bunu önlemek için lock objesi oluşturuldu. Her seferinde lock kontrolü yapmaması için de instance null check konuldu performans yavaşlamaması için.
                {
                    if(singleton == null) { //lazy loading yani nesneye ihtiyaç olduğunda oluşması sağlandı.
                        singleton = new Singleton();
                    }
                }
            }
            sayi++;
            System.Console.WriteLine(sayi);
            return singleton;
        }
    }
}