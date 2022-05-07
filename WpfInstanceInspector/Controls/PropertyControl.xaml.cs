using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Control for editing property of an object
    /// </summary>
    public partial class PropertyControl : UserControl
    {
        private object instance;
        private PropertyInfo propertyInfo;
        
        //public string PropertyName => this.propertyInfo.Name; 
        public string PropertyName => this.propertyInfo.Name;

        public object PropertyValue
        {
            get { return propertyInfo.GetValue(instance); }
            set { propertyInfo.SetValue(instance, value); }
        }

        public PropertyControl(object instance, PropertyInfo propertyInfo)
        {
            this.instance = instance;
            this.propertyInfo = propertyInfo;

            InitializeComponent();


            //.Items.Add(PropertyName);
        }
    }

    //For conversion between Int32 and double (for example using slider to set Int32 property)
    [ValueConversion(typeof(double), typeof(int))]
    public class DoubleInt32Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToDouble(value); ;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return System.Convert.ToInt32(value);
        }
    }
}
