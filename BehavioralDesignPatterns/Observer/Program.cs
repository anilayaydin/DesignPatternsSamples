using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal minTemperature = (Decimal)(23);
            Decimal maxTemperature = (Decimal)(28);

            Termometer termometer = new Termometer(minTemperature,maxTemperature);

            Parent mother = new Parent("Mary");
            Parent father = new Parent("Jack");

            termometer.add(mother);
            termometer.add(father);

            for(int i=(int)termometer.getMomentaryTemperature();i<=30;i++)
                termometer.setMomentaryTemperature((Decimal)(i));
            for(int i=(int)termometer.getMomentaryTemperature();i>=22;i--)
                termometer.setMomentaryTemperature((Decimal)(i));
        }
    }
}
