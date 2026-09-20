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

    public class QuotaResourceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>沙箱工具配额或当前用量</p><p>单位：个</p>
        /// </summary>
        [JsonProperty("SandboxTools")]
        public long? SandboxTools{ get; set; }

        /// <summary>
        /// <p>沙箱实例配额或当前用量</p><p>单位：个</p>
        /// </summary>
        [JsonProperty("SandboxInstances")]
        public long? SandboxInstances{ get; set; }

        /// <summary>
        /// <p>暂停实例配额或当前用量</p><p>单位：个</p>
        /// </summary>
        [JsonProperty("PausedInstances")]
        public long? PausedInstances{ get; set; }

        /// <summary>
        /// <p>暂停实例配额或当前用量。目前只在主账号中返回</p><p>单位：核</p>
        /// </summary>
        [JsonProperty("CPUCores")]
        public float? CPUCores{ get; set; }

        /// <summary>
        /// <p>内存配额或当前用量</p><p>单位：GiB</p>
        /// </summary>
        [JsonProperty("MemoryGiB")]
        public float? MemoryGiB{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SandboxTools", this.SandboxTools);
            this.SetParamSimple(map, prefix + "SandboxInstances", this.SandboxInstances);
            this.SetParamSimple(map, prefix + "PausedInstances", this.PausedInstances);
            this.SetParamSimple(map, prefix + "CPUCores", this.CPUCores);
            this.SetParamSimple(map, prefix + "MemoryGiB", this.MemoryGiB);
        }
    }
}

