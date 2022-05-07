using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfInstanceInspector
{
    internal class PropertyControlTemplateSelector : DataTemplateSelector
    {
        public DataTemplate IntegerTemplate { get; set; }
        public DataTemplate StringTemplate  { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item == null) return null;

            if (item is Int32)
                return IntegerTemplate;
            
            if (item is string)
                return StringTemplate;

            return base.SelectTemplate(item, container);
        }
    }
}
