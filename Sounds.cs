using System.IO;
using System.Media;

namespace FishNotify
{
    public class Sounds
    {
        private static readonly SoundPlayer player = new SoundPlayer();

        public static void PlaySound(Stream input)
        {
            lock (player)
            {
                Stop();

                player.Stream = input;
                player.Play();
            }
        }

        public static void Stop()
        {
            lock (player)
            {
                player.Stop();
                player.Stream = null;
            }
        }
    }
}
