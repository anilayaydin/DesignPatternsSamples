using System;
using System.Collections.Generic;

namespace Observer
{
    public abstract class Observable
    {
        private List<Observer> observerList;

       public Observable() {
           observerList=new List<Observer>();
       }
       public void add(Observer observer)
       {
           observerList.Add(observer);
       }
       public void remove(Observer observer)
       {
           observerList.Remove(observer);
       }
       public void alert()
       {            
           foreach(var observe in observerList)
           {
               observe.updateAlert(observe);
           }
       }

    }
}