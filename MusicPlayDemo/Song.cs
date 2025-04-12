using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayDemo
{
    public class Song
    {
        public string Album {  get; set; }
        public string Author { get; set; }

        public string Date { get; set; }

        private string _album;

        private string _author;
        private string _date;

        public Song(string album, string author, string date) 
        { 
            _album = album;
            _author = author;
            _date = date;
        }
    }
}
