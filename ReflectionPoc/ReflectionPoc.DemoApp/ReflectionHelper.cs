using System.Reflection;
using System.Text;

namespace ReflectionPoc.DemoApp
{
    public static class ReflectionHelper
    {
        public static string GetPropertyValueList(object inst)
        {
            Type type = inst.GetType();

            
            //BindingFlags enum describes which member of a type, we want.
            //e.g. if not interested in private or static properties.
            //DeclaredOnly Tells GetProperties() not to lookup base class properties

            PropertyInfo[] props = type.GetProperties(BindingFlags.Instance |
                                                      BindingFlags.Public |
                                                      BindingFlags.DeclaredOnly);
            var sb = new StringBuilder();
            foreach (PropertyInfo prop in props)
            {
                sb.AppendLine($"{prop.Name} {prop.GetValue(inst)}");
            }

            return sb.ToString();
        }
    }
}
