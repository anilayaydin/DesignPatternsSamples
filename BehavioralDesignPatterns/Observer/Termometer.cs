using System;

namespace Observer
{
    class Termometer:Observable
    {
        private Decimal momentaryTemperature;
        private Decimal minTemperature;
        private Decimal maxTemperature;
        public Termometer(Decimal minTemperature, Decimal maxTemperature)
        {
            this.minTemperature=minTemperature;
            this.maxTemperature=maxTemperature;
            this.momentaryTemperature=(Decimal)24;
        }

        public Decimal getMomentaryTemperature()
        {
            return momentaryTemperature;
        }

        public void setMomentaryTemperature(Decimal momentaryTemperature)
        {
            this.momentaryTemperature=momentaryTemperature;
            System.Console.WriteLine(momentaryTemperature);

            ControlTemperature();
        }

        private void ControlTemperature()
        {
            bool isTooHot=momentaryTemperature.CompareTo(maxTemperature)>=0;
            bool isTooCold=momentaryTemperature.CompareTo(minTemperature)<=0;

            if(isTooHot || isTooCold)
                alert();
        }

    }
}

