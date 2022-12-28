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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KeyValueInfo : AbstractModel
    {
        
        /// <summary>
        /// 需要配置键值或者元字段索引的字段名称，仅支持字母、数字和_-./@，且不能以_开头
        /// 
        /// 注意：
        /// 1，元字段（tag）的Key无需额外添加`__TAG__.`前缀，与上传日志时对应的字段Key一致即可，腾讯云控制台展示时将自动添加`__TAG__.`前缀
        /// 2，键值索引（KeyValue）及元字段索引（Tag）中的Key总数不能超过300
        /// 3，Key的层级不能超过10层，例如a.b.c.d.e.f.g.h.j.k
        /// 4，不允许同时包含json父子级字段，例如a及a.b
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 字段的索引描述信息
        /// </summary>
        [JsonProperty("Value")]
        public ValueInfo Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamObj(map, prefix + "Value.", this.Value);
        }
    }
}

