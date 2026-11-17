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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GPUResourceSpec : AbstractModel
    {
        
        /// <summary>
        /// <p>GPU 类型标识，例如 5090d。</p>
        /// </summary>
        [JsonProperty("GPUType")]
        public string GPUType{ get; set; }

        /// <summary>
        /// <p>GPU 类型展示名称；为空时使用 GPUType 展示。</p>
        /// </summary>
        [JsonProperty("GPUTypeAlias")]
        public string GPUTypeAlias{ get; set; }

        /// <summary>
        /// <p>单台实例全部 GPU 的总显存，单位 GiB；不需要再乘 GPUNum。0 表示展示元数据未维护。</p>
        /// </summary>
        [JsonProperty("GPUMemoryGiB")]
        public ulong? GPUMemoryGiB{ get; set; }

        /// <summary>
        /// <p>单台实例 CPU 核数。</p>
        /// </summary>
        [JsonProperty("CPU")]
        public ulong? CPU{ get; set; }

        /// <summary>
        /// <p>单台实例主机内存，单位 GiB；不是 GPU 显存。</p>
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// <p>单台实例的 GPU 卡数。</p>
        /// </summary>
        [JsonProperty("GPUNum")]
        public ulong? GPUNum{ get; set; }

        /// <summary>
        /// <p>当前可购买数量，单位台，不是卡数；0 表示确认无额度，null 表示额度未知。实际购买时仍会重新校验。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AvailableCount")]
        public ulong? AvailableCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GPUType", this.GPUType);
            this.SetParamSimple(map, prefix + "GPUTypeAlias", this.GPUTypeAlias);
            this.SetParamSimple(map, prefix + "GPUMemoryGiB", this.GPUMemoryGiB);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "GPUNum", this.GPUNum);
            this.SetParamSimple(map, prefix + "AvailableCount", this.AvailableCount);
        }
    }
}

