﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOP100_HandlingApp.Data
{
    public class Song
    {
        public Song()
        {
            Artist = string.Empty;
            Title = string.Empty;
        }
        public Song(int id, string artist, string title)
        {
            Id = id;
            Artist = artist;
            Title = title;
        }

        public int Id { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
    }
}
