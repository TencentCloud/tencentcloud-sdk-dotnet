/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KVNamespace : AbstractModel
    {
        
        /// <summary>
        /// 命名空间名称。在同站点下具有唯一性。
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 命名空间描述。创建时填写的备注信息，用于说明命名空间的用途或业务含义。最大支持 256 个字符。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// KV 存储空间可用容量，单位为字节（Byte）。表示该命名空间可存储数据的最大容量上限，当前默认为 1 GB。
        /// </summary>
        [JsonProperty("Capacity")]
        public long? Capacity{ get; set; }

        /// <summary>
        /// KV 存储空间已用容量，单位为字节（Byte）。表示该命名空间当前已使用的存储空间大小。
        /// </summary>
        [JsonProperty("CapacityUsed")]
        public long? CapacityUsed{ get; set; }

        /// <summary>
        /// 命名空间被引用实例的列表。展示当前命名空间被哪些边缘函数实例引用，以及引用的站点信息。若未被引用，则返回空数组。
        /// </summary>
        [JsonProperty("References")]
        public ComponentReference[] References{ get; set; }

        /// <summary>
        /// 命名空间的创建时间，遵循 ISO 8601 标准，格式为 YYYY-MM-DDThh:mm:ssZ（UTC 时间）。
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 命名空间的最后修改时间，遵循 ISO 8601 标准，格式为 YYYY-MM-DDThh:mm:ssZ（UTC 时间）。
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Capacity", this.Capacity);
            this.SetParamSimple(map, prefix + "CapacityUsed", this.CapacityUsed);
            this.SetParamArrayObj(map, prefix + "References.", this.References);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
        }
    }
}

