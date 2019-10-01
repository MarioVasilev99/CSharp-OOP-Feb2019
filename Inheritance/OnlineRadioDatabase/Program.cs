namespace OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();
            DateTime playlistLenght = new DateTime();

            for (int i = 0; i < numberOfSongs; i++)
            {
                // Read Song Data
                string[] songData = Console
                    .ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);

                // Get Song Data
                string artistName = songData[0];
                string songName = songData[1];
                string songLenghtString = songData[2];

                Song newSong;

                try
                {
                    newSong = new Song(artistName, songName, songLenghtString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                // Check if it exists already
                songs.Add(newSong);
                Console.WriteLine("Song added.");

                double secondsToAdd = newSong.Minutes * 60 + newSong.Seconds;

                playlistLenght = playlistLenght.AddSeconds(secondsToAdd);
                
            }

            // Print Total Songs Added
            Console.WriteLine($"Songs added: {songs.Count}");

            // Print Playlist Lenght ->  Ex. 0h 7m 47s
            Console.WriteLine($"Playlist length:" +
                $" {playlistLenght.Hour}h {playlistLenght.Minute}m {playlistLenght.Second}s");
        }
    }
}
