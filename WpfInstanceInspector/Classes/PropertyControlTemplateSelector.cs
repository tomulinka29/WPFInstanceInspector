using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfInstanceInspector
{
    internal class PropertyControlTemplateSelector : DataTemplateSelector
    {
        public DataTemplate IntegerTemplate { get; set; }
        public DataTemplate StringTemplate  { get; set; }
        public DataTemplate BoolTemplate { get; set; }
        public DataTemplate ColorTemplate { get; set; }
        public DataTemplate DelegateTemplate { get; set; }


        //Selects data template based on the data type
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null) return null;

            if (item is Int32)
                return IntegerTemplate;
            
            if (item is string)
                return StringTemplate;

            if (item is bool)
                return BoolTemplate;

            if (item is Color)
                return ColorTemplate;

            if (item is Delegate)
                return DelegateTemplate;

            return base.SelectTemplate(item, container);
        }
    }
}
