/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class ResourceConf : AbstractModel
    {
        
        /// <summary>
        /// cpu 处理器资源, 单位为1/1000核 (for预付费)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// memory 内存资源, 单位为1M (for预付费)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// gpu Gpu卡资源，单位为1/100卡，例如GpuType=T4时，1 Gpu = 1/100 T4卡 (for预付费)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Gpu")]
        public ulong? Gpu{ get; set; }

        /// <summary>
        /// GpuType 卡类型，参考资源组上对应的卡类型。eg: H800,A800,A100,T4,P4,V100等 (for预付费)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GpuType")]
        public string GpuType{ get; set; }

        /// <summary>
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
        /// TI.GN7.20XLARGE320.POST: 80C320G T4*4
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
            this.SetParamSimple(map, prefix + "GpuType", this.GpuType);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
        }
    }
}

