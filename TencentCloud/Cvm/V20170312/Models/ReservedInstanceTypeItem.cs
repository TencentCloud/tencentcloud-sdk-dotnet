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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReservedInstanceTypeItem : AbstractModel
    {
        
        /// <summary>
        /// 实例类型。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// CPU核数。
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// 内存大小。
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// GPU数量。
        /// </summary>
        [JsonProperty("Gpu")]
        public ulong? Gpu{ get; set; }

        /// <summary>
        /// FPGA数量。
        /// </summary>
        [JsonProperty("Fpga")]
        public ulong? Fpga{ get; set; }

        /// <summary>
        /// 本地存储块数量。
        /// </summary>
        [JsonProperty("StorageBlock")]
        public ulong? StorageBlock{ get; set; }

        /// <summary>
        /// 网卡数。
        /// </summary>
        [JsonProperty("NetworkCard")]
        public ulong? NetworkCard{ get; set; }

        /// <summary>
        /// 最大带宽。
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public float? MaxBandwidth{ get; set; }

        /// <summary>
        /// 主频。
        /// </summary>
        [JsonProperty("Frequency")]
        public string Frequency{ get; set; }

        /// <summary>
        /// CPU型号名称。
        /// </summary>
        [JsonProperty("CpuModelName")]
        public string CpuModelName{ get; set; }

        /// <summary>
        /// 包转发率。
        /// </summary>
        [JsonProperty("Pps")]
        public ulong? Pps{ get; set; }

        /// <summary>
        /// 外部信息。
        /// </summary>
        [JsonProperty("Externals")]
        public Externals Externals{ get; set; }

        /// <summary>
        /// 备注信息。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 预留实例配置价格信息。
        /// </summary>
        [JsonProperty("Prices")]
        public ReservedInstancePriceItem[] Prices{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
            this.SetParamSimple(map, prefix + "Fpga", this.Fpga);
            this.SetParamSimple(map, prefix + "StorageBlock", this.StorageBlock);
            this.SetParamSimple(map, prefix + "NetworkCard", this.NetworkCard);
            this.SetParamSimple(map, prefix + "MaxBandwidth", this.MaxBandwidth);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "CpuModelName", this.CpuModelName);
            this.SetParamSimple(map, prefix + "Pps", this.Pps);
            this.SetParamObj(map, prefix + "Externals.", this.Externals);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "Prices.", this.Prices);
        }
    }
}

