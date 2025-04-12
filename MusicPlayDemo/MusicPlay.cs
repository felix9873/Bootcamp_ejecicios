using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayDemo
{
    public class MusicPlay
    {
        public string Album {  get; set; }
        public string Author { get; set; }

        public string Date { get; set; }

        public MusicPlay(string album, string author, string date) 
        { 
            Album = album;
            Author = author;
            Date = date;
        }
    }
}
