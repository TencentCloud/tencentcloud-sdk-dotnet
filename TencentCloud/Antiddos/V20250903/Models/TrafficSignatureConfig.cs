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

namespace TencentCloud.Antiddos.V20250903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrafficSignatureConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>流量签名配置开关。</p>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// <p>流量签名密钥。</p>
        /// </summary>
        [JsonProperty("TrafficSignatureKeys")]
        public string[] TrafficSignatureKeys{ get; set; }

        /// <summary>
        /// <p>UDP 协议校验的端口范围，支持输入多个端口或端口范围。</p>
        /// </summary>
        [JsonProperty("UdpCheckPortRanges")]
        public PortRange[] UdpCheckPortRanges{ get; set; }

        /// <summary>
        /// <p>TCP 协议校验的端口范围，支持输入多个端口或端口范围。</p>
        /// </summary>
        [JsonProperty("TcpCheckPortRanges")]
        public PortRange[] TcpCheckPortRanges{ get; set; }

        /// <summary>
        /// <p>UDP 协议下签名在数据包负载中的起始偏移位置，支持 0 至 100 字节偏移量。默认为0。</p>
        /// </summary>
        [JsonProperty("UdpTrafficSignatureOffset")]
        public ulong? UdpTrafficSignatureOffset{ get; set; }

        /// <summary>
        /// <p>TCP 协议下签名在数据包负载中的起始偏移位置，支持 0 至 100 字节偏移量。默认为0</p>
        /// </summary>
        [JsonProperty("TcpTrafficSignatureOffset")]
        public long? TcpTrafficSignatureOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "TrafficSignatureKeys.", this.TrafficSignatureKeys);
            this.SetParamArrayObj(map, prefix + "UdpCheckPortRanges.", this.UdpCheckPortRanges);
            this.SetParamArrayObj(map, prefix + "TcpCheckPortRanges.", this.TcpCheckPortRanges);
            this.SetParamSimple(map, prefix + "UdpTrafficSignatureOffset", this.UdpTrafficSignatureOffset);
            this.SetParamSimple(map, prefix + "TcpTrafficSignatureOffset", this.TcpTrafficSignatureOffset);
        }
    }
}

