using System;

namespace Observer{

    public class Parent:Observer
    {
        private string name;
        public Parent(string name)
        {
            this.name=name;
        }
        public void updateAlert(Observer observable)
        {
            Termometer termometer = (Termometer) observable;
            System.Console.WriteLine(name + "says temperature is " + termometer.getMomentaryTemperature());            
        }

        public void update(Observable observable)
        {
            Termometer termometer = (Termometer) observable;
            System.Console.WriteLine(name + "says temperature is " + termometer.getMomentaryTemperature());            
        }
    }
}