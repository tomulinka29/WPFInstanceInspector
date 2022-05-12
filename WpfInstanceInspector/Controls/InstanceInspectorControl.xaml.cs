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
using WpfInstanceInspector.Controls;

namespace WpfInstanceInspector
{
    /// <summary>
    /// Interaction logic for InstanceInspectorControl.xaml
    /// </summary>
    public partial class InstanceInspectorControl : UserControl
    { 
        public InstanceInspectorControl(InstanceModel instanceModel)
        {
            InitializeComponent();

            PropertyInfo[] propertyInfos = instanceModel.GetPropertyInfos();
            foreach (var propertyInfo in propertyInfos)
                sp_PropsPanel.Children.Add(new PropertyControl(instanceModel.Instance, propertyInfo));
            
        }
    }
}
