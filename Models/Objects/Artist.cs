﻿namespace MusicLibrary.Models.Objects
{
    public class Artist
    {
        public Artist() => Musics = new HashSet<Music>();



        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;




        public ICollection<Music> Musics { get; set; }
    }
}
