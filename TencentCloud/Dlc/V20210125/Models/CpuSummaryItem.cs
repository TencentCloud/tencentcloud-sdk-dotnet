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

    public class CpuSummaryItem : AbstractModel
    {
        
        /// <summary>
        /// <p>CPU 总核数（headCpu + cpu × replicas 的总和）</p>
        /// </summary>
        [JsonProperty("TotalCpuCores")]
        public long? TotalCpuCores{ get; set; }

        /// <summary>
        /// <p>内存总量（headMem + mem × replicas 的总和，单位 GB）</p>
        /// </summary>
        [JsonProperty("TotalMemoryGB")]
        public long? TotalMemoryGB{ get; set; }

        /// <summary>
        /// <p>运行中的副本总数</p>
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCpuCores", this.TotalCpuCores);
            this.SetParamSimple(map, prefix + "TotalMemoryGB", this.TotalMemoryGB);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
        }
    }
}

