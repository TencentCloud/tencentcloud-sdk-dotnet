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
        /// 角色，eg：PS、WORKER、DRIVER、EXECUTOR
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// cpu核数，使用资源组时需配置。单位：1/1000，即1000=1核
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// 内存，使用资源组时需配置。单位为MB
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// gpu卡类型，使用资源组时需配置
        /// </summary>
        [JsonProperty("GpuType")]
        public string GpuType{ get; set; }

        /// <summary>
        /// gpu卡数，使用资源组时需配置。单位：1/100，即100=1卡
        /// </summary>
        [JsonProperty("Gpu")]
        public ulong? Gpu{ get; set; }

        /// <summary>
        /// 算力规格ID
        /// 计算规格 (for后付费)，可选值如下：
        /// TI.S.LARGE.POST: 4C8G 
        /// TI.S.2XLARGE16.POST:  8C16G 
        /// TI.S.2XLARGE32.POST:  8C32G 
        /// TI.S.4XLARGE32.POST:  16C32G
        /// TI.S.4XLARGE64.POST:  16C64G
        /// TI.S.6XLARGE48.POST:  24C48G
        /// TI.S.6XLARGE96.POST:  24C96G
        /// TI.S.8XLARGE64.POST:  32C64G
        /// TI.S.8XLARGE128.POST : 32C128G
        /// TI.GN10.2XLARGE40.POST: 8C40G V100*1 
        /// TI.GN10.5XLARGE80.POST:  18C80G V100*2 
        /// TI.GN10.10XLARGE160.POST :  32C160G V100*4
        /// TI.GN10.20XLARGE320.POST :  72C320G V100*8
        /// TI.GN7.8XLARGE128.POST: 32C128G T4*1 
        /// TI.GN7.10XLARGE160.POST: 40C160G T4*2 
        /// TI.GN7.20XLARGE320.POST: 80C32
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 计算节点数
        /// </summary>
        [JsonProperty("InstanceNum")]
        public ulong? InstanceNum{ get; set; }

        /// <summary>
        /// 算力规格名称
        /// 计算规格 (for后付费)，可选值如下：
        /// 4C8G 
        /// 8C16G 
        /// 8C32G 
        /// 16C32G
        /// 6C64G
        /// 24C48G
        /// 24C96G
        /// 32C64G
        /// 32C128G
        /// 8C40G V100*1 
        /// 8C80G V100*2 
        /// 32C160G V100*4
        /// 72C320G V100*8
        /// 32C128G T4*1 
        /// 40C160G T4*2 
        /// 80C32
        /// </summary>
        [JsonProperty("InstanceTypeAlias")]
        public string InstanceTypeAlias{ get; set; }

        /// <summary>
        /// RDMA配置
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

