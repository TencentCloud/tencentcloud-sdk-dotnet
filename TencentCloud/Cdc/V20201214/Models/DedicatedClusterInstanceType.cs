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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DedicatedClusterInstanceType : AbstractModel
    {
        
        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 网卡类型，例如：25代表25G网卡
        /// </summary>
        [JsonProperty("NetworkCard")]
        public long? NetworkCard{ get; set; }

        /// <summary>
        /// 实例的CPU核数，单位：核。
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 实例内存容量，单位：`GB`。
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 实例机型系列。
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// 机型名称。
        /// </summary>
        [JsonProperty("TypeName")]
        public string TypeName{ get; set; }

        /// <summary>
        /// 本地存储块数量。
        /// </summary>
        [JsonProperty("StorageBlockAmount")]
        public long? StorageBlockAmount{ get; set; }

        /// <summary>
        /// 内网带宽，单位Gbps。
        /// </summary>
        [JsonProperty("InstanceBandwidth")]
        public float? InstanceBandwidth{ get; set; }

        /// <summary>
        /// 网络收发包能力，单位万PPS。
        /// </summary>
        [JsonProperty("InstancePps")]
        public long? InstancePps{ get; set; }

        /// <summary>
        /// 处理器型号。
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// 实例的GPU数量。
        /// </summary>
        [JsonProperty("Gpu")]
        public long? Gpu{ get; set; }

        /// <summary>
        /// 实例的FPGA数量。
        /// </summary>
        [JsonProperty("Fpga")]
        public long? Fpga{ get; set; }

        /// <summary>
        /// 机型描述
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 实例是否售卖。取值范围： <br><li>SELL：表示实例可购买<br><li>SOLD_OUT：表示实例已售罄。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "NetworkCard", this.NetworkCard);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "InstanceFamily", this.InstanceFamily);
            this.SetParamSimple(map, prefix + "TypeName", this.TypeName);
            this.SetParamSimple(map, prefix + "StorageBlockAmount", this.StorageBlockAmount);
            this.SetParamSimple(map, prefix + "InstanceBandwidth", this.InstanceBandwidth);
            this.SetParamSimple(map, prefix + "InstancePps", this.InstancePps);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
            this.SetParamSimple(map, prefix + "Fpga", this.Fpga);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

