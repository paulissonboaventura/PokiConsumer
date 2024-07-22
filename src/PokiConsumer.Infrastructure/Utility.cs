using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokiConsumer.Infrastructure
{
    public static class Utility
    {
        public static T GetPropertyValue<T>(this T obj, string propertyName) where T : class
        {
            var vv = typeof(T).GetProperty(propertyName).GetValue(obj);
            return (T)vv;
        }
    }
}
