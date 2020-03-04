using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week_3_Code_Along
{
    class Dog
    {
        public string Bread;
        public int Height;
        public string Name;

        public void Bark()
        {
            MessageBox.Show("Bark");
        }

        public void SayName()
        {
            MessageBox.Show("Salutations Homoerectus descendent, so your name is " + Name + "?");
        }
    }
}
