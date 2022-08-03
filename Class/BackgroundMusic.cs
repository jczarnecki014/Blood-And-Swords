using System.Media;
    class BackgroundMusic
    {
        private static string SoundPath {
            get 
            {
                return @"..\..\..\sounds\";
            }
        }
        public BackgroundMusic(string soundName)
        { 
            SoundPlayer newPlayer = new SoundPlayer();
            newPlayer.SoundLocation = SoundPath+soundName+".wav";
            newPlayer.Play();
        }
    }

