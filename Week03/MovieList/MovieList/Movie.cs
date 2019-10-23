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
        public string Title { get; set;  }
        public int ReleaseYear { get; set;  }
        public string Director { get; set;  }
        public int Length { get; set; }
        public string Genre { get; set;  }
        public double RottenTomatoes { get; set;  }

        public Movie(string title, int releaseYear, string director, int length, string genre, double rottenTomatoes)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
            Length = length;
            Genre = genre;
            RottenTomatoes = rottenTomatoes;
        }

        public void ShowDetails()
        {
            MessageBox.Show(Title + "This movie was released in " + ReleaseYear + "The director is " + Director + "The length is " + Length + "The genre is " + Genre + "The rotten tomato score is" + RottenTomatoes);
        }
    }
}
