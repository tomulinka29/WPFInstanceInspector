using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfInstanceInspector
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ExampleClass1 exampleClass1;
        public MainWindow()
        {
            InitializeComponent();
            exampleClass1 = new ExampleClass1(){ Age = 15, Name = "Petr"};
            PropertyInfo[] propertyInfo = exampleClass1.GetType().GetProperties();

            //grid_mainGrid.Children.Add(new PropertyControl(exampleClass1, propertyInfo[0]));
            grid_mainGrid.Children.Add(new InstanceInspectorControl(exampleClass1));
            /*foreach (var pi in propertyInfo)
            {
                MessageBox.Show(pi.ToString() + "\nType: " + pi.PropertyType.Name);
            }*/

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show( exampleClass1.Name + "\n" + exampleClass1.Age.ToString() + "\n" + exampleClass1.Depressed.ToString());
        }
    }
}
