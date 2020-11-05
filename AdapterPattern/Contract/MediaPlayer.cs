using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Contract
{
    public interface MediaPlayer
    {
        void play(string autoType, string fileName);
    }
}
