using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Media;
using System.IO;

namespace CyberSecurityAwarenessBot.Services
{
    public static class AudioPlayer
    {
        public static void PlayPrincess(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    SoundPlayer player = new SoundPlayer(filePath);
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("[Audio file not found. Continuing without voice greeting.]");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Could not play audio: {ex.Message}]");
            }
        }
    }
}


