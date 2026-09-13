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

    public class InferenceHardwareConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>推理服务单个实例分配的 GPU 卡数，当前仅支持整数值，且必须为 <code>HardwareSpecId</code> 对应规格的 <code>AllowedGPUNums</code> 中的可选值。</p><p>若不填充，则使用所选 <code>HardwareSpecId</code> 规格对应的默认 <code>GPUNum</code> 值。</p>
        /// </summary>
        [JsonProperty("GPUNum")]
        public float? GPUNum{ get; set; }

        /// <summary>
        /// <p>推理服务单个实例分配的 CPU 核数，当前仅支持整数值。</p><p>若不填充，则使用所选 <code>HardwareSpecId</code> 规格对应的默认 <code>CPUNum</code> 值。</p>
        /// </summary>
        [JsonProperty("CPUNum")]
        public float? CPUNum{ get; set; }

        /// <summary>
        /// <p>推理服务单实例分配的内存大小。</p><p>单位：MB</p><p>若不填充，则使用所选 <code>HardwareSpecId</code> 对应规格的默认 <code>MemSize</code> 值；若填充，则必须为 <code>1024</code> 的整数倍。</p>
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// <p>推理服务单实例分配的临时磁盘大小。</p><p>单位：MB</p><p>若不填充，则使用所选 <code>HardwareSpecId</code> 对应规格的默认 <code>DiskSize</code> 值；若填充，则必须为 <code>1024</code> 的整数倍。</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GPUNum", this.GPUNum);
            this.SetParamSimple(map, prefix + "CPUNum", this.CPUNum);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
        }
    }
}

