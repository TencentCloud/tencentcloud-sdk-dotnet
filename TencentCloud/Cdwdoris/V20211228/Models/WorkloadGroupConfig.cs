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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkloadGroupConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>资源组名称</p>
        /// </summary>
        [JsonProperty("WorkloadGroupName")]
        public string WorkloadGroupName{ get; set; }

        /// <summary>
        /// <p>CPU权重</p>
        /// </summary>
        [JsonProperty("CpuShare")]
        public long? CpuShare{ get; set; }

        /// <summary>
        /// <p>内存限制，所有资源组的内存限制值之和应该小于等于100</p>
        /// </summary>
        [JsonProperty("MemoryLimit")]
        public long? MemoryLimit{ get; set; }

        /// <summary>
        /// <p>是否允许超配分配</p>
        /// </summary>
        [JsonProperty("EnableMemoryOverCommit")]
        public bool? EnableMemoryOverCommit{ get; set; }

        /// <summary>
        /// <p>cpu硬限制</p>
        /// </summary>
        [JsonProperty("CpuHardLimit")]
        public string CpuHardLimit{ get; set; }

        /// <summary>
        /// <p>4.1+ 新增；默认值为 0（不预留），根据业务可设为 5/10</p>
        /// </summary>
        [JsonProperty("MinCpuPercent")]
        public long? MinCpuPercent{ get; set; }

        /// <summary>
        /// <p>4.1+ 新增；默认值为 0（不预留），根据业务可设为 5/10</p>
        /// </summary>
        [JsonProperty("MinMemoryPercent")]
        public long? MinMemoryPercent{ get; set; }

        /// <summary>
        /// <p>2.1+ 新增；不传走内核默认（Integer.MAX_VALUE=2147483647），建议按业务并发量配置</p>
        /// </summary>
        [JsonProperty("MaxConcurrencyNum")]
        public long? MaxConcurrencyNum{ get; set; }

        /// <summary>
        /// <p>2.1+ 新增；0=不排队，建议为 MaxConcurrencyNum 的 50%</p>
        /// </summary>
        [JsonProperty("MaxQueueSize")]
        public long? MaxQueueSize{ get; set; }

        /// <summary>
        /// <p>2.1+ 新增；单位 ms，建议 5000（5s）</p>
        /// </summary>
        [JsonProperty("QueueTimeout")]
        public long? QueueTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkloadGroupName", this.WorkloadGroupName);
            this.SetParamSimple(map, prefix + "CpuShare", this.CpuShare);
            this.SetParamSimple(map, prefix + "MemoryLimit", this.MemoryLimit);
            this.SetParamSimple(map, prefix + "EnableMemoryOverCommit", this.EnableMemoryOverCommit);
            this.SetParamSimple(map, prefix + "CpuHardLimit", this.CpuHardLimit);
            this.SetParamSimple(map, prefix + "MinCpuPercent", this.MinCpuPercent);
            this.SetParamSimple(map, prefix + "MinMemoryPercent", this.MinMemoryPercent);
            this.SetParamSimple(map, prefix + "MaxConcurrencyNum", this.MaxConcurrencyNum);
            this.SetParamSimple(map, prefix + "MaxQueueSize", this.MaxQueueSize);
            this.SetParamSimple(map, prefix + "QueueTimeout", this.QueueTimeout);
        }
    }
}

