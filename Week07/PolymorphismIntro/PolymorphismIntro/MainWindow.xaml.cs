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

namespace PolymorphismIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Animal> Animals;
        public MainWindow()
        {
            InitializeComponent();
            Animals = new ObservableCollection<Animal>();

            Dog dog1 = new Dog("Muppet", 20, "Rolf");
            Dog dog2 = new Dog("Golden Retriever", 30, "Air Bud");
            Duck duck1 = new Duck(9, "Donald");

            Frog frog1 = new Frog(4, "Kermit", false);
            duck1.SayName();
            frog1.SayName();

            Animals.Add(dog1);
            Animals.Add(dog2);
            Animals.Add(duck1);
            Animals.Add(frog1);

            LvAnimals.ItemsSource = Animals;
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
        }

        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            Duck duck = new Duck();
            duck.Quack();
        }

        private void Ribbit_Button_Click(object sender, RoutedEventArgs e)
        {
            Frog frog = new Frog();
            frog.Ribbit();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {

        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (Animal a in Animals)
            {
                a.SayName();
            }
        }
        private void LvAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Animal selectedAnimal = LvAnimals.SelectedItem as Animal;
            if (selectedAnimal != null)
            {

            }
        }
    }
}
  
