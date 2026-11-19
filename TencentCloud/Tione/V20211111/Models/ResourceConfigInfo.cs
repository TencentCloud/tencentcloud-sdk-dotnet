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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceConfigInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>角色，eg：PS、WORKER、DRIVER、EXECUTOR</p>
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// <p>cpu核数，使用资源组时需配置。单位：1/1000，即1000=1核</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// <p>内存，使用资源组时需配置。单位为MB</p>
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// <p>gpu卡类型，使用资源组时需配置</p>
        /// </summary>
        [JsonProperty("GpuType")]
        public string GpuType{ get; set; }

        /// <summary>
        /// <p>gpu卡数，使用资源组时需配置。单位：1/100，即100=1卡</p>
        /// </summary>
        [JsonProperty("Gpu")]
        public ulong? Gpu{ get; set; }

        /// <summary>
        /// <p>算力规格ID<br>计算规格 (for后付费)，可选值如下：<br>TI.S.LARGE.POST: 4C8G<br>TI.S.2XLARGE16.POST:  8C16G<br>TI.S.2XLARGE32.POST:  8C32G<br>TI.S.4XLARGE32.POST:  16C32G<br>TI.S.4XLARGE64.POST:  16C64G<br>TI.S.6XLARGE48.POST:  24C48G<br>TI.S.6XLARGE96.POST:  24C96G<br>TI.S.8XLARGE64.POST:  32C64G<br>TI.S.8XLARGE128.POST : 32C128G<br>TI.GN10.2XLARGE40.POST: 8C40G V100<em>1<br>TI.GN10.5XLARGE80.POST:  18C80G V100</em>2<br>TI.GN10.10XLARGE160.POST :  32C160G V100<em>4<br>TI.GN10.20XLARGE320.POST :  72C320G V100</em>8<br>TI.GN7.8XLARGE128.POST: 32C128G T4<em>1<br>TI.GN7.10XLARGE160.POST: 40C160G T4</em>2<br>TI.GN7.20XLARGE320.POST: 80C32</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>计算节点数</p>
        /// </summary>
        [JsonProperty("InstanceNum")]
        public ulong? InstanceNum{ get; set; }

        /// <summary>
        /// <p>算力规格名称<br>计算规格 (for后付费)，可选值如下：<br>4C8G<br>8C16G<br>8C32G<br>16C32G<br>6C64G<br>24C48G<br>24C96G<br>32C64G<br>32C128G<br>8C40G V100<em>1<br>8C80G V100</em>2<br>32C160G V100<em>4<br>72C320G V100</em>8<br>32C128G T4<em>1<br>40C160G T4</em>2<br>80C32</p>
        /// </summary>
        [JsonProperty("InstanceTypeAlias")]
        public string InstanceTypeAlias{ get; set; }

        /// <summary>
        /// <p>RDMA配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RDMAConfig")]
        public RDMAConfig RDMAConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "GpuType", this.GpuType);
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamSimple(map, prefix + "InstanceTypeAlias", this.InstanceTypeAlias);
            this.SetParamObj(map, prefix + "RDMAConfig.", this.RDMAConfig);
        }
    }
}

