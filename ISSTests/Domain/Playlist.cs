using System;
using System.Collections.Generic;
namespace App.Domain
{
    public class Playlist
    {
        public int id { get; }
        public List<Song> songs { get; set; }
        public string name { get; set; } = string.Empty;

        public Playlist(string name)
        {
            this.name = name;
        }

        public Playlist(int id, string name)
        {
            this.name = name;
        }

        public Playlist(int id, string name, List<Song> songs)
        {
            this.id = id;
            this.name = name;
            this.songs = songs;
        }

        public bool addSong(Song song)
        {
            this.songs.Add(song);
            return true;
        }

/*        public bool removeSong(int songId)
        {
        foreach (Song song in this.songs)
            {
                if (song.id == songId)
                {
                    this.songs.Remove(song);
                    return true;
                }
            }
            return false; 
        }*/

    }

}