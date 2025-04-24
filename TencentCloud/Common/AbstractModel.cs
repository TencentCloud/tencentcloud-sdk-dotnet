/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TencentCloud.Common
{
    /// <summary>
    ///   Abstract base class for all request and response models.
    ///   Provides common functionality for serializing and deserializing data.
    /// </summary>
    public abstract class AbstractModel
    {
        /// <summary>
        ///   Abstract method to convert the model's data into a dictionary.
        ///   This method must be implemented by derived classes to define how their specific data is mapped.
        /// </summary>
        /// <param name="map">The dictionary to store the model's data.</param>
        /// <param name="prefix">A prefix to add to the parameter names (used for nested objects).</param>
        public abstract void ToMap(Dictionary<string, string> map, string prefix);

        /// <summary>
        ///   Sets a simple (non-object, non-array) parameter in the dictionary.
        ///   Handles null values, default values, and parameter name formatting.
        /// </summary>
        /// <typeparam name="V">The type of the parameter value (e.g., string, int, bool).</typeparam>
        /// <param name="map">The dictionary to store the parameter.</param>
        /// <param name="key">The original parameter name.</param>
        /// <param name="value">The parameter value.</param>
        protected void SetParamSimple<V>(Dictionary<string, string> map, String key, V value)
        {
            if ((value != null) && !value.Equals(default(V)))
            {
                // Format the key:
                // -   Capitalize the first letter.
                // -   Replace underscores with dots.
                key = key.Substring(0, 1).ToUpper() + key.Substring(1);
                key = key.Replace("_", ".");
                map.Add(key, value.ToString());
            }
        }

        /// <summary>
        ///   Sets a simple parameter that is an array in the dictionary.
        ///   Iterates through the array and calls SetParamSimple for each element.
        /// </summary>
        /// <typeparam name="V">The type of the array elements.</typeparam>
        /// <param name="map">The dictionary to store the parameters.</param>
        /// <param name="prefix">The prefix to add to the parameter names (e.g., "Items.").</param>
        /// <param name="array">The array of values.</param>
        protected void SetParamArraySimple<V>(Dictionary<string, string> map, string prefix, V[] array)
        {
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    this.SetParamSimple<V>(map, prefix + i, array[i]);
                }
            }
        }

        /// <summary>
        ///   Sets an object parameter in the dictionary.
        ///   Recursively calls the ToMap method of the object to handle nested data.
        /// </summary>
        /// <typeparam name="V">The type of the object, which must inherit from AbstractModel.</typeparam>
        /// <param name="map">The dictionary to store the parameter.</param>
        /// <param name="prefix">The prefix to add to the parameter names (e.g., "Item.").</param>
        /// <param name="obj">The object to set as the parameter.</param>
        protected void SetParamObj<V>(Dictionary<string, string> map, String prefix, V obj) where V : AbstractModel
        {
            if (obj != null)
            {
                obj.ToMap(map, prefix);
            }
        }

        /// <summary>
        ///   Sets an array of objects as a parameter in the dictionary.
        ///   Iterates through the array and calls SetParamObj for each object.
        /// </summary>
        /// <typeparam name="V">The type of the array elements, which must inherit from AbstractModel.</typeparam>
        /// <param name="map">The dictionary to store the parameters.</param>
        /// <param name="prefix">The prefix to add to the parameter names (e.g., "Items.").</param>
        /// <param name="array">The array of objects.</param>
        protected void SetParamArrayObj<V>(Dictionary<String, String> map, String prefix, V[] array)
            where V : AbstractModel
        {
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    this.SetParamObj<V>(map, prefix + i + ".", array[i]);
                }
            }
        }

        /// <summary>
        ///   Serializes an object of AbstractModel into a JSON string.
        /// </summary>
        /// <typeparam name="V">A class inherited from AbstractModel.</typeparam>
        /// <param name="obj">An object of the class.</param>
        /// <returns>JSON formatted string representing the object.</returns>
        public static string ToJsonString<V>(V obj) where V : AbstractModel
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        ///   Deserializes a JSON formatted string into an object of a class inherited from AbstractModel.
        /// </summary>
        /// <typeparam name="V">A class inherited from AbstractModel.</typeparam>
        /// <param name="json">The JSON formatted string to deserialize.</param>
        /// <returns>An object of the class.</returns>
        public static V FromJsonString<V>(string json)
        {
            return JsonConvert.DeserializeObject<V>(json);
        }

        /// <summary>
        ///   Indicates whether the model represents a stream (e.g., for file uploads/downloads).
        ///   Defaults to false; derived classes can override this if needed.
        /// </summary>
        [JsonIgnore]
        public virtual bool IsStream => false;
    }
}