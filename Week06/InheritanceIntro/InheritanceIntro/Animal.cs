using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
   public class Animal : Organism
    {
        public string Name;
        public string Breed;

        public void SayName()
        {
            MessageBox.Show("My name is " + this.Name);
        }

        public Animal() { }
    }
}
