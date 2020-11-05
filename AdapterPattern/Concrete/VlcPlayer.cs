using AdapterPattern.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Concrete
{
    public class VlcPlayer : AdvancedMediaPlayer
    {
        public void playMp4(string filename)
        {
            throw new NotImplementedException();
        }

        public void playVlc(string filename)
        {
            Console.WriteLine($"Playing vlc file. Name: {filename}");
        }
    }
}
