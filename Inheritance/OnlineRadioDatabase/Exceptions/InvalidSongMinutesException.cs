namespace OnlineRadioDatabase
{
    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        public InvalidSongMinutesException(string message)
            : base(message)
        {
        }
    }
}
