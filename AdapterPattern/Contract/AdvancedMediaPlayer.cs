using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Contract
{
    public interface AdvancedMediaPlayer
    {
        void playVlc(string filename);
        void playMp4(string filename);
    }
}
