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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OverviewNorthSouthDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>南北向互联网总带宽，单位为 Mbps。</p><p>单位：Mbps</p>
        /// </summary>
        [JsonProperty("InternetBandwidthTotalMbps")]
        public float? InternetBandwidthTotalMbps{ get; set; }

        /// <summary>
        /// <p>南北向网络峰值流量，单位为 bps。</p><p>单位：bps</p>
        /// </summary>
        [JsonProperty("NetMaxFlowBps")]
        public float? NetMaxFlowBps{ get; set; }

        /// <summary>
        /// <p>串行接入总带宽，单位为 Mbps。</p><p>单位：Mbps</p>
        /// </summary>
        [JsonProperty("SerialBandwidthTotalMbps")]
        public long? SerialBandwidthTotalMbps{ get; set; }

        /// <summary>
        /// <p>NAT 防火墙总带宽，单位为 Mbps。</p><p>单位：Mbps</p>
        /// </summary>
        [JsonProperty("NatBandwidthTotalMbps")]
        public long? NatBandwidthTotalMbps{ get; set; }

        /// <summary>
        /// <p>仅旁路接入带宽，单位为 Mbps。</p><p>单位：Mbps</p>
        /// </summary>
        [JsonProperty("BypassOnlyBandwidthMbps")]
        public long? BypassOnlyBandwidthMbps{ get; set; }

        /// <summary>
        /// <p>未使用带宽，单位为 Mbps。</p><p>单位：Mbps</p>
        /// </summary>
        [JsonProperty("UnusedBandwidthMbps")]
        public long? UnusedBandwidthMbps{ get; set; }

        /// <summary>
        /// <p>当前仍可使用带宽，单位为 Mbps。</p><p>单位：Mbps</p>
        /// </summary>
        [JsonProperty("CanUsedBandwidthMbps")]
        public long? CanUsedBandwidthMbps{ get; set; }

        /// <summary>
        /// <p>串行链路峰值流量最高的地域名称。</p>
        /// </summary>
        [JsonProperty("MaxSerialRegion")]
        public string MaxSerialRegion{ get; set; }

        /// <summary>
        /// <p>峰值最高地域的入站流量峰值，单位为 bps。</p><p>单位：bps</p>
        /// </summary>
        [JsonProperty("SerialRegionInFlowMax")]
        public long? SerialRegionInFlowMax{ get; set; }

        /// <summary>
        /// <p>峰值最高地域的出方向最大流量，单位为 bps。</p><p>单位：bps</p>
        /// </summary>
        [JsonProperty("SerialRegionOutFlowMax")]
        public long? SerialRegionOutFlowMax{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InternetBandwidthTotalMbps", this.InternetBandwidthTotalMbps);
            this.SetParamSimple(map, prefix + "NetMaxFlowBps", this.NetMaxFlowBps);
            this.SetParamSimple(map, prefix + "SerialBandwidthTotalMbps", this.SerialBandwidthTotalMbps);
            this.SetParamSimple(map, prefix + "NatBandwidthTotalMbps", this.NatBandwidthTotalMbps);
            this.SetParamSimple(map, prefix + "BypassOnlyBandwidthMbps", this.BypassOnlyBandwidthMbps);
            this.SetParamSimple(map, prefix + "UnusedBandwidthMbps", this.UnusedBandwidthMbps);
            this.SetParamSimple(map, prefix + "CanUsedBandwidthMbps", this.CanUsedBandwidthMbps);
            this.SetParamSimple(map, prefix + "MaxSerialRegion", this.MaxSerialRegion);
            this.SetParamSimple(map, prefix + "SerialRegionInFlowMax", this.SerialRegionInFlowMax);
            this.SetParamSimple(map, prefix + "SerialRegionOutFlowMax", this.SerialRegionOutFlowMax);
        }
    }
}

