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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowRealtimeStatusSRT : AbstractModel
    {
        
        /// <summary>
        /// 延迟，单位为ms。
        /// </summary>
        [JsonProperty("Latency")]
        public long? Latency{ get; set; }

        /// <summary>
        /// RTT，单位为ms。
        /// </summary>
        [JsonProperty("RTT")]
        public long? RTT{ get; set; }

        /// <summary>
        /// 实时发包数或者收包数。
        /// </summary>
        [JsonProperty("Packets")]
        public long? Packets{ get; set; }

        /// <summary>
        /// 丢包率。
        /// </summary>
        [JsonProperty("PacketLossRate")]
        public float? PacketLossRate{ get; set; }

        /// <summary>
        /// 重传率。
        /// </summary>
        [JsonProperty("RetransmitRate")]
        public float? RetransmitRate{ get; set; }

        /// <summary>
        /// 实时丢包数。
        /// </summary>
        [JsonProperty("DroppedPackets")]
        public long? DroppedPackets{ get; set; }

        /// <summary>
        /// 是否加密，On|Off。
        /// </summary>
        [JsonProperty("Encryption")]
        public string Encryption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Latency", this.Latency);
            this.SetParamSimple(map, prefix + "RTT", this.RTT);
            this.SetParamSimple(map, prefix + "Packets", this.Packets);
            this.SetParamSimple(map, prefix + "PacketLossRate", this.PacketLossRate);
            this.SetParamSimple(map, prefix + "RetransmitRate", this.RetransmitRate);
            this.SetParamSimple(map, prefix + "DroppedPackets", this.DroppedPackets);
            this.SetParamSimple(map, prefix + "Encryption", this.Encryption);
        }
    }
}

