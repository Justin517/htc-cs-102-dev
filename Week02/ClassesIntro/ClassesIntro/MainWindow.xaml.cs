using System.Windows;

namespace ClassesIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Name = " Bob";
            dog.Bark();
            dog.SayName();
        }
      
        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            string dogName = DogName.Text;

            Dog dog = new Dog("Corgi", 12, dogName);
            //dog.SayName();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Drop(object sender, DragEventArgs e)
        {

        }
    }
}
