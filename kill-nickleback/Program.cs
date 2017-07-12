using System;
using System.Collections.Generic;

namespace kill_nickleback
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string artist, string title)> GoodSongs = new List<(string artist, string title)>();
            HashSet<(string artist, string title)> AllSongs = new HashSet<(string artist, string title)>()
            {
                ("Nickelback", "Photograph"),
                ("Butch Walker", "Weight of the World"),
                ("The Rolling Stones", "19th Nervous Breakdown"),
                ("Nickelback", "Another Shitty Song"),
                ("The Beatles", "Lucy in the Sky"),
                ("The Black Keys", "Next Girl"),
                ("Nickelback", "Some other song that sounds like the other 2")
            };

            foreach (var song in AllSongs)
            {
                if (song.artist != "Nickelback")
                {
                    GoodSongs.Add(song);
                }
            }

            foreach (var song in GoodSongs)
            {
                Console.WriteLine($"{song.title} by {song.artist}");
            }          
        }
    }
}
