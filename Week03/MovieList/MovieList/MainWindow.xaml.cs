using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Movie> Movies = new ObservableCollection<Movie>();
        public MainWindow()
        {
            InitializeComponent();
            lvMovies.ItemsSource = Movies;
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            
          
            string title = titleInput.Text;
            int releaseYear = Convert.ToInt32(releaseYearInput.Text);
            string director = directorInput.Text;
            int length = Convert.ToInt32(lengthInput.Text);
            string genre = genreInput.Text;
            double rottenTomatoes = Convert.ToDouble(rottenTomatoInput.Text);

            Movie movie = new Movie(title, releaseYear, director, length, genre, rottenTomatoes);
            if (Movies.Count == 0)
            {
                Movies.Add(movie);
                MessageBox.Show("Movie was added");
            }
            else
            {
                foreach (Movie film in Movies)
                {
                    if (title == film.Title)
                    {
                        MessageBox.Show("That movie is already in the list");
                    }
                    else
                    {
                        Movies.Add(movie);
                        MessageBox.Show("Movie was added");
                    }
                }
            }
          
           
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in Movies)
            {
                MessageBox.Show("The movie is " + movie.Title + "\r\n" + "The movie was released in " + movie.ReleaseYear + "\r\n" + "The Movies director is " + movie.Director + "\r\n" + "The length of the movie is " + movie.Length + "\r\n" + "The genre is " + movie.Genre + "/r/n" + "The rotten tomato score is " + movie.RottenTomatoes);
            }
        }

        private void lvMovies_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Movie selectedMovie = lvMovies.SelectedItem as Movie;
            if (selectedMovie != null)
            {
                selectedMovie.ShowDetails();
            }
        }
    }
}
