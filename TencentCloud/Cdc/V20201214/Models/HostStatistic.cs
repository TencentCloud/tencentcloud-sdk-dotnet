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

    public class HostStatistic : AbstractModel
    {
        
        /// <summary>
        /// 宿主机规格
        /// </summary>
        [JsonProperty("HostType")]
        public string HostType{ get; set; }

        /// <summary>
        /// 宿主机机型系列
        /// </summary>
        [JsonProperty("HostFamily")]
        public string HostFamily{ get; set; }

        /// <summary>
        /// 宿主机的CPU核数，单位：核
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// 宿主机内存大小，单位：GB
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 该规格宿主机的数量
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 平均cpu负载百分比
        /// </summary>
        [JsonProperty("CpuAverage")]
        public float? CpuAverage{ get; set; }

        /// <summary>
        /// 平均内存使用率百分比
        /// </summary>
        [JsonProperty("MemAverage")]
        public float? MemAverage{ get; set; }

        /// <summary>
        /// 平均网络流量
        /// </summary>
        [JsonProperty("NetAverage")]
        public float? NetAverage{ get; set; }

        /// <summary>
        /// cpu详细监控数据
        /// </summary>
        [JsonProperty("CpuDetailData")]
        public DetailData CpuDetailData{ get; set; }

        /// <summary>
        /// 内存详细数据
        /// </summary>
        [JsonProperty("MemDetailData")]
        public DetailData MemDetailData{ get; set; }

        /// <summary>
        /// 网络速率详细数据
        /// </summary>
        [JsonProperty("NetRateDetailData")]
        public DetailData NetRateDetailData{ get; set; }

        /// <summary>
        /// 网速包详细数据
        /// </summary>
        [JsonProperty("NetPacketDetailData")]
        public DetailData NetPacketDetailData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostType", this.HostType);
            this.SetParamSimple(map, prefix + "HostFamily", this.HostFamily);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "CpuAverage", this.CpuAverage);
            this.SetParamSimple(map, prefix + "MemAverage", this.MemAverage);
            this.SetParamSimple(map, prefix + "NetAverage", this.NetAverage);
            this.SetParamObj(map, prefix + "CpuDetailData.", this.CpuDetailData);
            this.SetParamObj(map, prefix + "MemDetailData.", this.MemDetailData);
            this.SetParamObj(map, prefix + "NetRateDetailData.", this.NetRateDetailData);
            this.SetParamObj(map, prefix + "NetPacketDetailData.", this.NetPacketDetailData);
        }
    }
}

