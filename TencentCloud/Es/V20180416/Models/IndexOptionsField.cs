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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IndexOptionsField : AbstractModel
    {
        
        /// <summary>
        /// <p>过期时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireMaxAge")]
        public string ExpireMaxAge{ get; set; }

        /// <summary>
        /// <p>过期大小</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireMaxSize")]
        public string ExpireMaxSize{ get; set; }

        /// <summary>
        /// <p>滚动周期</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RolloverMaxAge")]
        public string RolloverMaxAge{ get; set; }

        /// <summary>
        /// <p>是否开启动态滚动</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RolloverDynamic")]
        public string RolloverDynamic{ get; set; }

        /// <summary>
        /// <p>是否开启动态分片</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShardNumDynamic")]
        public string ShardNumDynamic{ get; set; }

        /// <summary>
        /// <p>时间分区字段</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimestampField")]
        public string TimestampField{ get; set; }

        /// <summary>
        /// <p>写入模式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WriteMode")]
        public string WriteMode{ get; set; }

        /// <summary>
        /// <p>是否开启完全卸载</p><p>枚举值：</p><ul><li>true： 开启完全卸载</li><li>false： 关闭完全卸载</li></ul>
        /// </summary>
        [JsonProperty("FullOffloadedEnable")]
        public string FullOffloadedEnable{ get; set; }

        /// <summary>
        /// <p>完全卸载生命周期</p>
        /// </summary>
        [JsonProperty("FullOffloadedMaxAge")]
        public string FullOffloadedMaxAge{ get; set; }

        /// <summary>
        /// <p>完全卸载后备索引取回后生命周期</p>
        /// </summary>
        [JsonProperty("FullOffloadedRetrieveMaxAge")]
        public string FullOffloadedRetrieveMaxAge{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExpireMaxAge", this.ExpireMaxAge);
            this.SetParamSimple(map, prefix + "ExpireMaxSize", this.ExpireMaxSize);
            this.SetParamSimple(map, prefix + "RolloverMaxAge", this.RolloverMaxAge);
            this.SetParamSimple(map, prefix + "RolloverDynamic", this.RolloverDynamic);
            this.SetParamSimple(map, prefix + "ShardNumDynamic", this.ShardNumDynamic);
            this.SetParamSimple(map, prefix + "TimestampField", this.TimestampField);
            this.SetParamSimple(map, prefix + "WriteMode", this.WriteMode);
            this.SetParamSimple(map, prefix + "FullOffloadedEnable", this.FullOffloadedEnable);
            this.SetParamSimple(map, prefix + "FullOffloadedMaxAge", this.FullOffloadedMaxAge);
            this.SetParamSimple(map, prefix + "FullOffloadedRetrieveMaxAge", this.FullOffloadedRetrieveMaxAge);
        }
    }
}

