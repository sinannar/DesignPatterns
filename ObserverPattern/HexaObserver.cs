using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class HexaObserver : Observer
    {
        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void update()
        {
            Console.WriteLine("Binary String: " + subject.getState().ToString("X"));
        }
    }
}
