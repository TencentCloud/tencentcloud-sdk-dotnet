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
    public abstract class AbstractModel
    {
        internal abstract void ToMap(Dictionary<string, string> map, string prefix);

        protected void SetParamSimple<V>(Dictionary<string, string> map, String key, V value)
        {
            if ((value!= null) && !value.Equals(default(V)) )
            {
                key = key.Substring(0, 1).ToUpper() + key.Substring(1);
                key = key.Replace("_", ".");
                map.Add(key, value.ToString());
            }
        }

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

        protected void SetParamObj<V>(Dictionary<string, string> map, String prefix, V obj)  where V: AbstractModel
        {
            if (obj != null)
            {
                obj.ToMap(map, prefix);
            }
        }

        protected  void SetParamArrayObj<V>(Dictionary<String, String> map, String prefix, V[] array) where V : AbstractModel
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
        /// 序列化函数，将对象数据转化为json格式的string
        /// </summary>
        /// <typeparam name="V">继承自AbstractModel的子类型</typeparam>
        /// <param name="obj">子实例</param>
        /// <returns>json格式的string</returns>
        public static string ToJsonString<V>(V obj) where V: AbstractModel
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        ///  序列化函数，根据传入的json格式的string实例化一个cls对象返回
        /// </summary>
        /// <typeparam name="V"></typeparam>
        /// <param name="json">json格式的string</param>
        /// <returns>与json匹配的类对象</returns>
        public static V FromJsonString<V>(string json) 
        {
            return JsonConvert.DeserializeObject<V>(json);
        }
    }
}
