using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        public string Title;
        public int ReleaseYear;
        public string Director;
        public int Length;
        public string Genre;

        public Movie(string title, int releaseYear, string director, int length, string genre)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
            Length = length;
            Genre = genre;
        }

        public void ShowDetails()
        {
            MessageBox.Show(Title + "This movie was released in " + ReleaseYear + "The director is " + Director + "The length is " + Length + "The genre is " + Genre);
        }
    }
}
