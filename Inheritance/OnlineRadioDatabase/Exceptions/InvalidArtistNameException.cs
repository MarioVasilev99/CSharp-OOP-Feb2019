namespace OnlineRadioDatabase
{
    public class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException(string message)
            :base(message)
        {
        }
    }
}
