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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoProfilingConfig : AbstractModel
    {
        
        /// <summary>
        /// 自动CPU剖析任务开关
        /// </summary>
        [JsonProperty("CpuProfilingEnable")]
        public bool? CpuProfilingEnable{ get; set; }

        /// <summary>
        /// 自动内存剖析任务开关
        /// </summary>
        [JsonProperty("MemoryProfilingEnable")]
        public bool? MemoryProfilingEnable{ get; set; }

        /// <summary>
        /// 自动CPU剖析任务阈值
        /// </summary>
        [JsonProperty("CpuProfilingThreshold")]
        public long? CpuProfilingThreshold{ get; set; }

        /// <summary>
        /// 自动内存剖析任务阈值
        /// </summary>
        [JsonProperty("MemoryProfilingThreshold")]
        public long? MemoryProfilingThreshold{ get; set; }

        /// <summary>
        /// CPU自动剖析任务时长
        /// </summary>
        [JsonProperty("CpuProfilingDuration")]
        public long? CpuProfilingDuration{ get; set; }

        /// <summary>
        /// 内存自动剖析任务时长
        /// </summary>
        [JsonProperty("MemoryProfilingDuration")]
        public long? MemoryProfilingDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CpuProfilingEnable", this.CpuProfilingEnable);
            this.SetParamSimple(map, prefix + "MemoryProfilingEnable", this.MemoryProfilingEnable);
            this.SetParamSimple(map, prefix + "CpuProfilingThreshold", this.CpuProfilingThreshold);
            this.SetParamSimple(map, prefix + "MemoryProfilingThreshold", this.MemoryProfilingThreshold);
            this.SetParamSimple(map, prefix + "CpuProfilingDuration", this.CpuProfilingDuration);
            this.SetParamSimple(map, prefix + "MemoryProfilingDuration", this.MemoryProfilingDuration);
        }
    }
}

