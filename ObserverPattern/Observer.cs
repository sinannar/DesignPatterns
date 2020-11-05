using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void update();
    }
}
