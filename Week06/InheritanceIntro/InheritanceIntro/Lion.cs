using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    public class Lion : Animal
    {
        public bool Mane;

        public Lion () { }

        public Lion(int height, string name, bool mane)
        {
            this.Height = height;
            this.Name = name;
            this.Mane = mane;
        }
        public void Roar()
        {
            MessageBox.Show("ROAR");
        }
    }
}
