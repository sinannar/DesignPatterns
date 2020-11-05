using AdapterPattern.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Concrete
{
    public class MediaAdapter : MediaPlayer
    {
        AdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(string type)
        {
            if (string.Equals(type.ToLower(), "vlc"))
            {
                advancedMediaPlayer = new VlcPlayer();
            }
            if (string.Equals(type.ToLower(), "mp4"))
            {
                advancedMediaPlayer = new Mp4Player();
            }
        }

        public void play(string autoType, string fileName)
        {
            if (string.Equals(autoType.ToLower(), "vlc"))
            {
                advancedMediaPlayer.playVlc(fileName);
            }
            if (string.Equals(autoType.ToLower(), "mp4"))
            {
                advancedMediaPlayer.playMp4(fileName);
            }
        }
    }
}
