using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;

        public int getState()
        {
            return state;
        }

        public void setState(int state)
        {
            this.state = state;
            notifyAllObservers();
        }

        public void attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void notifyAllObservers()
        {
            foreach (var observer in observers)
            {
                observer.update();
            }
        }
    }
}
