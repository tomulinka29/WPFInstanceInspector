

using System.Reflection;

namespace WpfInstanceInspector.Controls
{
    public class InstanceModel
    {
        public object Instance { get; private set; }

        public InstanceModel(object instance) {  this.Instance = instance; }
    
        public PropertyInfo[] GetPropertyInfos() => Instance.GetType().GetProperties();
    }
}
