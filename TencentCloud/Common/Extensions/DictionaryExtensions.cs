using System;
using System.Collections.Generic;

namespace TencentCloud.Common.Extensions
{
    internal static class DictionaryExtensions
    {
        public static Dictionary<string, string> AddParam<T>(this Dictionary<string, string> map, string key, T value)
        {
            if (value != null && !value.Equals(default(T)))
            {
                key = key.Substring(0, 1).ToUpper() + key.Substring(1);
                key = key.Replace("_", ".");
                map.Add(key, value.ToString());
            }

            return map;
        }

        public static Dictionary<string, string> AddArray<T>(this Dictionary<string, string> map, string prefix, T[] array)
        {
            if (array != null)
            {
                for (var i = 0; i < array.Length; i++)
                {
                    AddParam(map, prefix + i, array[i]);
                }
            }

            return map;
        }

        public static Dictionary<string, string> AddParamObj<V>(this Dictionary<string, string> map, string prefix, V obj) 
            where V : AbstractModel
        {
            if (obj != null)
            {
                obj.ToMap(map, prefix);
            }
            
            return map;
        }

       public static Dictionary<string, string> SetParamArrayObj<T>(this Dictionary<string, string> map, string prefix, T[] array)
            where T : AbstractModel
        {
            if (array != null)
            {
                for (var i = 0; i < array.Length; i++)
                {
                    AddParamObj(map, prefix + i + ".", array[i]);
                }
            }

            return map;
        }
    }
}