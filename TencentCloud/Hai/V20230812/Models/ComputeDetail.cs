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

namespace TencentCloud.Hai.V20230812.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComputeDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>算力套餐ID</p>
        /// </summary>
        [JsonProperty("BundleType")]
        public string BundleType{ get; set; }

        /// <summary>
        /// <p>节点数量</p>
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// <p>显卡数量</p>
        /// </summary>
        [JsonProperty("GPUCount")]
        public string GPUCount{ get; set; }

        /// <summary>
        /// <p>显存</p>
        /// </summary>
        [JsonProperty("GPUMemory")]
        public string GPUMemory{ get; set; }

        /// <summary>
        /// <p>算力</p>
        /// </summary>
        [JsonProperty("GPUPerformance")]
        public string GPUPerformance{ get; set; }

        /// <summary>
        /// <p>CPU核数</p>
        /// </summary>
        [JsonProperty("CPU")]
        public string CPU{ get; set; }

        /// <summary>
        /// <p>内存</p>
        /// </summary>
        [JsonProperty("Memory")]
        public string Memory{ get; set; }

        /// <summary>
        /// <p>该套餐是否支持包年包月</p>
        /// </summary>
        [JsonProperty("PrepaidEnable")]
        public bool? PrepaidEnable{ get; set; }

        /// <summary>
        /// <p>该套餐是否支持按量计费</p>
        /// </summary>
        [JsonProperty("PostpaidEnable")]
        public bool? PostpaidEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BundleType", this.BundleType);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "GPUCount", this.GPUCount);
            this.SetParamSimple(map, prefix + "GPUMemory", this.GPUMemory);
            this.SetParamSimple(map, prefix + "GPUPerformance", this.GPUPerformance);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "PrepaidEnable", this.PrepaidEnable);
            this.SetParamSimple(map, prefix + "PostpaidEnable", this.PostpaidEnable);
        }
    }
}

