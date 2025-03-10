using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotCyberSecurity
{
    internal class AudioPlayer
    {
        public void Play()
        {
            string filePath = "files/welcome_audio.wav"; // Ensure the file is in the correct directory
            using (SoundPlayer player = new SoundPlayer(filePath))
            {
                player.PlaySync(); // Use Play() for async playback
            }
        }
    }
}
