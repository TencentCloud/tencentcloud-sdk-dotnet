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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EdgeNodeResourceInfo : AbstractModel
    {
        
        /// <summary>
        /// 可使用的CPU 单位: m核
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllocatedCPU")]
        public string AllocatedCPU{ get; set; }

        /// <summary>
        /// CPU总量 单位:m核
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalCPU")]
        public string TotalCPU{ get; set; }

        /// <summary>
        /// 已分配的内存 单位G
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllocatedMemory")]
        public string AllocatedMemory{ get; set; }

        /// <summary>
        /// 内存总量 单位G
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalMemory")]
        public string TotalMemory{ get; set; }

        /// <summary>
        /// 已分配的GPU资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllocatedGPU")]
        public string AllocatedGPU{ get; set; }

        /// <summary>
        /// GPU总量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalGPU")]
        public string TotalGPU{ get; set; }

        /// <summary>
        /// 可使用的CPU 单位: m核
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvailableCPU")]
        public string AvailableCPU{ get; set; }

        /// <summary>
        /// 可使用的内存 单位: G
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvailableMemory")]
        public string AvailableMemory{ get; set; }

        /// <summary>
        /// 可使用的GPU资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvailableGPU")]
        public string AvailableGPU{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllocatedCPU", this.AllocatedCPU);
            this.SetParamSimple(map, prefix + "TotalCPU", this.TotalCPU);
            this.SetParamSimple(map, prefix + "AllocatedMemory", this.AllocatedMemory);
            this.SetParamSimple(map, prefix + "TotalMemory", this.TotalMemory);
            this.SetParamSimple(map, prefix + "AllocatedGPU", this.AllocatedGPU);
            this.SetParamSimple(map, prefix + "TotalGPU", this.TotalGPU);
            this.SetParamSimple(map, prefix + "AvailableCPU", this.AvailableCPU);
            this.SetParamSimple(map, prefix + "AvailableMemory", this.AvailableMemory);
            this.SetParamSimple(map, prefix + "AvailableGPU", this.AvailableGPU);
        }
    }
}

