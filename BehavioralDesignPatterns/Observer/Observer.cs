using System;

namespace Observer
{
    public interface Observer
    {
        void update(Observable observable);

        void updateAlert(Observer observer);

    }
}