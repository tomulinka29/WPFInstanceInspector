using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WpfInstanceInspector
{
    internal class ExampleClass1
    {
        public delegate void OnFinished();

        public int Age { get; set; }

        public string Name { get; set; }

        public bool Weird { get; set; }

        public Color SkinColor { get; set; }

        public OnFinished F { get; set; }
       
        public ExampleClass1()
        {
            F = A;
        }

        public void A()
        {
            MessageBox.Show("Clicked");
        }


    }
}
