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
        private readonly  object instance;
        private readonly  PropertyInfo propertyInfo;

        public string PropertyName => this.propertyInfo.Name;

        public object PropertyValue
        {
            get => this.propertyInfo.GetValue(instance);
            set => this.propertyInfo.SetValue(instance, value);
        }

        public PropertyControl(object instance, PropertyInfo propertyInfo)
        {
            InitializeComponent();

            this.instance = instance;
            this.propertyInfo = propertyInfo;
            lBox.Items.Add(PropertyValue);
            
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
