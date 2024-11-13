using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_3
{
    public class Song
    {
        // Private member variables for song details
        private string title;
        private string artist;
        private double duration;
        private int playCount;

        // Constructor to initialize the song with title, artist, and duration
        public Song(string songTitle, string songArtist, double songDuration)
        {
            title = songTitle;
            artist = songArtist;
            duration = songDuration;
            playCount = 0; // Play count starts at 0
        }

        // Method to play the song and increment the play count
        public void Play()
        {
            playCount++;
            Console.WriteLine("Playing " + title + " by " + artist);
        }

        // Method to display song information, including play count
        public void ShowInfo()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Artist: " + artist);
            Console.WriteLine("Duration: " + duration + " minutes");
            Console.WriteLine("Play Count: " + playCount);
        }
    }

}
