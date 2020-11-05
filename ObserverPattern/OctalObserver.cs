using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }

        public override void update()
        {
            Console.WriteLine("Binary String: " + Convert.ToString(subject.getState(), 8));
        }
    }
}
