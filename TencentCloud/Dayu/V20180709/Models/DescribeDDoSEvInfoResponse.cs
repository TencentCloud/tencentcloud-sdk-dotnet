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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDDoSEvInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 大禹子产品代号（bgpip表示高防IP；bgp表示独享包；bgp-multip表示共享包；net表示高防IP专业版）
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 资源的IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 攻击开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 攻击结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// TCP报文攻击包数
        /// </summary>
        [JsonProperty("TcpPacketSum")]
        public ulong? TcpPacketSum{ get; set; }

        /// <summary>
        /// TCP报文攻击流量，单位KB
        /// </summary>
        [JsonProperty("TcpKBSum")]
        public ulong? TcpKBSum{ get; set; }

        /// <summary>
        /// UDP报文攻击包数
        /// </summary>
        [JsonProperty("UdpPacketSum")]
        public ulong? UdpPacketSum{ get; set; }

        /// <summary>
        /// UDP报文攻击流量，单位KB
        /// </summary>
        [JsonProperty("UdpKBSum")]
        public ulong? UdpKBSum{ get; set; }

        /// <summary>
        /// ICMP报文攻击包数
        /// </summary>
        [JsonProperty("IcmpPacketSum")]
        public ulong? IcmpPacketSum{ get; set; }

        /// <summary>
        /// ICMP报文攻击流量，单位KB
        /// </summary>
        [JsonProperty("IcmpKBSum")]
        public ulong? IcmpKBSum{ get; set; }

        /// <summary>
        /// 其他报文攻击包数
        /// </summary>
        [JsonProperty("OtherPacketSum")]
        public ulong? OtherPacketSum{ get; set; }

        /// <summary>
        /// 其他报文攻击流量，单位KB
        /// </summary>
        [JsonProperty("OtherKBSum")]
        public ulong? OtherKBSum{ get; set; }

        /// <summary>
        /// 累计攻击流量，单位KB
        /// </summary>
        [JsonProperty("TotalTraffic")]
        public ulong? TotalTraffic{ get; set; }

        /// <summary>
        /// 攻击流量带宽峰值
        /// </summary>
        [JsonProperty("Mbps")]
        public ulong? Mbps{ get; set; }

        /// <summary>
        /// 攻击包速率峰值
        /// </summary>
        [JsonProperty("Pps")]
        public ulong? Pps{ get; set; }

        /// <summary>
        /// PCAP文件下载链接
        /// </summary>
        [JsonProperty("PcapUrl")]
        public string[] PcapUrl{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TcpPacketSum", this.TcpPacketSum);
            this.SetParamSimple(map, prefix + "TcpKBSum", this.TcpKBSum);
            this.SetParamSimple(map, prefix + "UdpPacketSum", this.UdpPacketSum);
            this.SetParamSimple(map, prefix + "UdpKBSum", this.UdpKBSum);
            this.SetParamSimple(map, prefix + "IcmpPacketSum", this.IcmpPacketSum);
            this.SetParamSimple(map, prefix + "IcmpKBSum", this.IcmpKBSum);
            this.SetParamSimple(map, prefix + "OtherPacketSum", this.OtherPacketSum);
            this.SetParamSimple(map, prefix + "OtherKBSum", this.OtherKBSum);
            this.SetParamSimple(map, prefix + "TotalTraffic", this.TotalTraffic);
            this.SetParamSimple(map, prefix + "Mbps", this.Mbps);
            this.SetParamSimple(map, prefix + "Pps", this.Pps);
            this.SetParamArraySimple(map, prefix + "PcapUrl.", this.PcapUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

