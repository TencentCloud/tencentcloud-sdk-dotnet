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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceSpec : AbstractModel
    {
        
        /// <summary>
        /// <p>资源包类型</p>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>机型，例如X40/T20，仅GU有值</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>四层计费项</p>
        /// </summary>
        [JsonProperty("BillingItem")]
        public string BillingItem{ get; set; }

        /// <summary>
        /// <p>规格描述</p>
        /// </summary>
        [JsonProperty("SpecDesc")]
        public string SpecDesc{ get; set; }

        /// <summary>
        /// <p>规格，格式为 {gpu}:{cpu}:{mem}:{vram}</p>
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// <p>GPU类型，仅GU有值</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GpuType")]
        public string GpuType{ get; set; }

        /// <summary>
        /// <p>单个物理节点上该计费项对应的最大 GPU 卡数，CPU / HM_CPU 恒为 0</p>
        /// </summary>
        [JsonProperty("MaxCardPerNode")]
        public long? MaxCardPerNode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "BillingItem", this.BillingItem);
            this.SetParamSimple(map, prefix + "SpecDesc", this.SpecDesc);
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "GpuType", this.GpuType);
            this.SetParamSimple(map, prefix + "MaxCardPerNode", this.MaxCardPerNode);
        }
    }
}

