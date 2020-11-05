using AdapterPattern.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Concrete
{
    public class Mp4Player : AdvancedMediaPlayer
    {
        public void playMp4(string filename)
        {
            Console.WriteLine($"Playing mp4 file. Name: {filename}");
        }

        public void playVlc(string filename)
        {
            throw new NotImplementedException();
        }
    }
}
