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

    public class DescribeGPUResourceSpecsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>GPU 类型标识，例如 5090d；指定时必须同时提供 CPU、Memory、GPUNum。</p>
        /// </summary>
        [JsonProperty("GPUType")]
        public string GPUType{ get; set; }

        /// <summary>
        /// <p>CPU 核数，必须为正数；与 GPUType、Memory、GPUNum 同时提供。</p>
        /// </summary>
        [JsonProperty("CPU")]
        public ulong? CPU{ get; set; }

        /// <summary>
        /// <p>主机内存 GiB，必须为正数；与 GPUType、CPU、GPUNum 同时提供。</p>
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// <p>单台 GPU 卡数，必须为正整数；与 GPUType、CPU、Memory 同时提供。</p>
        /// </summary>
        [JsonProperty("GPUNum")]
        public ulong? GPUNum{ get; set; }

        /// <summary>
        /// <p>分页偏移量，默认为 0，必须大于等于 0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>每页条数，省略或传 0 时取 100；非零取值范围 1–500。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GPUType", this.GPUType);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "GPUNum", this.GPUNum);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

