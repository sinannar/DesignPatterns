using AdapterPattern.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Concrete
{
    public class AudioPlayer : MediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void play(string audioType, string fileName)
        {
            if (string.Equals(audioType.ToLower(), "mp3"))
            {
                Console.WriteLine($"Playing mp3 file. Name: {fileName}");
            }
            else if (string.Equals(audioType.ToLower(), "vlc") || string.Equals(audioType.ToLower(), "mp4"))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.play(audioType, fileName);
            }
            else
            {
                Console.WriteLine($"Invalid media. {audioType} format not supported");
            }
        }
    }
}
