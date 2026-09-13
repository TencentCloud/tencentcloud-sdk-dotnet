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

    public class InferenceHardwareSpecification : AbstractModel
    {
        
        /// <summary>
        /// <p>规格标识。已废弃，参考使用字段 <code>HardwareSpecId</code>。</p>
        /// </summary>
        [JsonProperty("Spec")]
        [System.Obsolete]
        public string Spec{ get; set; }

        /// <summary>
        /// <p>规格唯一标识 ID。</p>
        /// </summary>
        [JsonProperty("HardwareSpecId")]
        public string HardwareSpecId{ get; set; }

        /// <summary>
        /// <p>规格名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>规格默认分配的 GPU 卡数。</p>
        /// </summary>
        [JsonProperty("GPUNum")]
        public float? GPUNum{ get; set; }

        /// <summary>
        /// <p>规格默认分配的 CPU 核数。</p>
        /// </summary>
        [JsonProperty("CPUNum")]
        public float? CPUNum{ get; set; }

        /// <summary>
        /// <p>规格默认分配的内存大小。</p><p>单位：MB</p>
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// <p>规格默认分配的显存大小。</p><p>单位：MB</p>
        /// </summary>
        [JsonProperty("GPUMemSize")]
        public long? GPUMemSize{ get; set; }

        /// <summary>
        /// <p>规格默认分配的磁盘大小。</p><p>单位：MB</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// <p>规格当前支持的 GPU 卡数列表。</p><p>若不填充或填充空数组，则仅支持规格默认分配的 GPU 卡数。</p>
        /// </summary>
        [JsonProperty("AllowedGPUNums")]
        public float?[] AllowedGPUNums{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "HardwareSpecId", this.HardwareSpecId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "GPUNum", this.GPUNum);
            this.SetParamSimple(map, prefix + "CPUNum", this.CPUNum);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "GPUMemSize", this.GPUMemSize);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamArraySimple(map, prefix + "AllowedGPUNums.", this.AllowedGPUNums);
        }
    }
}

