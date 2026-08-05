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

    public class EngineCapabilities : AbstractModel
    {
        
        /// <summary>
        /// <p>GPU 是否可选</p>
        /// </summary>
        [JsonProperty("GpuOptional")]
        public bool? GpuOptional{ get; set; }

        /// <summary>
        /// <p>是否支持并行配置</p>
        /// </summary>
        [JsonProperty("SupportsParallelConfig")]
        public bool? SupportsParallelConfig{ get; set; }

        /// <summary>
        /// <p>是否支持远程代码</p>
        /// </summary>
        [JsonProperty("SupportsRemoteCode")]
        public bool? SupportsRemoteCode{ get; set; }

        /// <summary>
        /// <p>GPU 显存配置键名</p>
        /// </summary>
        [JsonProperty("GpuMemoryKey")]
        public string GpuMemoryKey{ get; set; }

        /// <summary>
        /// <p>并行配置键名列表</p>
        /// </summary>
        [JsonProperty("ParallelKeys")]
        public ParallelKeyMapping[] ParallelKeys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GpuOptional", this.GpuOptional);
            this.SetParamSimple(map, prefix + "SupportsParallelConfig", this.SupportsParallelConfig);
            this.SetParamSimple(map, prefix + "SupportsRemoteCode", this.SupportsRemoteCode);
            this.SetParamSimple(map, prefix + "GpuMemoryKey", this.GpuMemoryKey);
            this.SetParamArrayObj(map, prefix + "ParallelKeys.", this.ParallelKeys);
        }
    }
}

