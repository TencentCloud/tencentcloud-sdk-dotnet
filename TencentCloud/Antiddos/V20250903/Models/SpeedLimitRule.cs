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

    public class SpeedLimitRule : AbstractModel
    {
        
        /// <summary>
        /// <p>IP 协议号。取值参考 <a href="https://en.wikipedia.org/wiki/List_of_IP_protocol_numbers">IP 协议号列表</a> 。</p><p>参数格式：0-255 范围的数字。支持单个 IP 协议号和 IP 协议号范围。</p><p><code>0-255</code> 表示全部协议。</p>
        /// </summary>
        [JsonProperty("IPProtocolNumbers")]
        public string[] IPProtocolNumbers{ get; set; }

        /// <summary>
        /// <p>目的端口范围列表。</p>
        /// </summary>
        [JsonProperty("DestinationPortRanges")]
        public PortRange[] DestinationPortRanges{ get; set; }

        /// <summary>
        /// <p>限速统计维度。</p><p>枚举值：</p><ul><li>destination_ip： 按目的 IP 维度统计。</li><li>source_destination_ip： 按源 IP + 目的 IP 维度统计。</li></ul>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>流量带宽限制。</p><p>取值范围：[0, 4294967295]</p><p>单位：bps</p><p>为 0 时表示不限制。BandwidthLimit 和 PacketRateLimit 至少需要设置一个大于 0 的值。</p>
        /// </summary>
        [JsonProperty("BandwidthLimit")]
        public ulong? BandwidthLimit{ get; set; }

        /// <summary>
        /// <p>包速率限制。</p><p>取值范围：[0, 4294967295]</p><p>单位：pps</p><p>为 0 时表示不限制。BandwidthLimit 和 PacketRateLimit 至少需要设置一个大于 0 的值。</p>
        /// </summary>
        [JsonProperty("PacketRateLimit")]
        public ulong? PacketRateLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "IPProtocolNumbers.", this.IPProtocolNumbers);
            this.SetParamArrayObj(map, prefix + "DestinationPortRanges.", this.DestinationPortRanges);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "BandwidthLimit", this.BandwidthLimit);
            this.SetParamSimple(map, prefix + "PacketRateLimit", this.PacketRateLimit);
        }
    }
}

