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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExecutorUsageTrendInfo : AbstractModel
    {
        
        /// <summary>
        /// 时间戳，单位：毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// CPU占用百分比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CpuUsagePercent")]
        public float? CpuUsagePercent{ get; set; }

        /// <summary>
        /// 内存占用百分比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemUsagePercent")]
        public float? MemUsagePercent{ get; set; }

        /// <summary>
        /// 当前并发度使用百分比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConcurrencyUsage")]
        public float? ConcurrencyUsage{ get; set; }

        /// <summary>
        /// oceanus CU使用百分比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OceanusCuUsage")]
        public float? OceanusCuUsage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "CpuUsagePercent", this.CpuUsagePercent);
            this.SetParamSimple(map, prefix + "MemUsagePercent", this.MemUsagePercent);
            this.SetParamSimple(map, prefix + "ConcurrencyUsage", this.ConcurrencyUsage);
            this.SetParamSimple(map, prefix + "OceanusCuUsage", this.OceanusCuUsage);
        }
    }
}

