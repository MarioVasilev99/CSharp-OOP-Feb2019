namespace OnlineRadioDatabase
{
    using System.Linq;

    public class Song
    {
        private string artist;
        private string name;
        private int minutes;
        private int seconds;

        public Song(string artist, string name, string songLenght)
        {
            this.Artist = artist;
            this.Name = name;
            this.ValidateSongLenght(songLenght);

            int[] songData = songLenght.Split(":").Select(int.Parse).ToArray();

            int minutes = songData[0];
            int seconds = songData[1];

            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public string Artist
        {
            get => this.artist;
            private set
            {
                this.ValidateArtist(value);
                this.artist = value;
            }
        }

        public string Name
        {
            get => this.name;
            private set
            {
                this.ValidateSongName(value);
                this.name = value;
            }
        }

        public int Minutes
        {
            get => this.minutes;
            private set
            {
                this.ValidateMinutes(value);
                this.minutes = value;
            }
        }

        public int Seconds
        {
            get => this.seconds;
            private set
            {
                this.ValidateSeconds(value);
                this.seconds = value;
            }
        }

        private void ValidateArtist(string value)
        {
            if (value.Length <= 3 || value.Length >= 20)
            {
                throw new
                    InvalidArtistNameException("Artist name should be between 3 and 20 symbols.");
            }
        }

        private void ValidateSongName(string value)
        {
            if (value.Length <= 3 || value.Length >= 30)
            {
                throw new InvalidSongNameException("Song name should be between 3 and 30 symbols.");
            }
        }

        private void ValidateMinutes(int value)
        {
            if (value < 0 || value > 14)
            {
                throw new InvalidSongMinutesException("Song minutes should be between 0 and 14.");
            }
        }

        private void ValidateSeconds(int value)
        {
            if (value < 0 || value > 59)
            {
                throw new InvalidSongSecondsException("Song seconds should be between 0 and 59.");
            }
        }

        private void ValidateSongLenght(string value)
        {
            string[] songData = value.Split(":");

            string minutesAsString = songData[0];
            string secondsAsString = songData[1];

            if (minutesAsString.Any(c => char.IsDigit(c) == false)
               || secondsAsString.Any(c => char.IsDigit(c) == false)
               || songData.Length != 2)
            {
                throw new InvalidSongLengthException("Invalid song length.");
            }
        }
    }
}
