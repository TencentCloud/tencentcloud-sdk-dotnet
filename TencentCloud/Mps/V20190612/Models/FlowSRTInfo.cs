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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowSRTInfo : AbstractModel
    {
        
        /// <summary>
        /// 时间戳，单位是秒。
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// 发送丢包率。
        /// </summary>
        [JsonProperty("SendPacketLossRate")]
        public long? SendPacketLossRate{ get; set; }

        /// <summary>
        /// 发送重传率。
        /// </summary>
        [JsonProperty("SendRetransmissionRate")]
        public long? SendRetransmissionRate{ get; set; }

        /// <summary>
        /// 接收丢包率。
        /// </summary>
        [JsonProperty("RecvPacketLossRate")]
        public long? RecvPacketLossRate{ get; set; }

        /// <summary>
        /// 接收重传率。
        /// </summary>
        [JsonProperty("RecvRetransmissionRate")]
        public long? RecvRetransmissionRate{ get; set; }

        /// <summary>
        /// 与对端的RTT时延。
        /// </summary>
        [JsonProperty("RTT")]
        public long? RTT{ get; set; }

        /// <summary>
        /// 标志同一次推流。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 发送弃包数。
        /// </summary>
        [JsonProperty("SendPacketDropNumber")]
        public long? SendPacketDropNumber{ get; set; }

        /// <summary>
        /// 接收弃包数。
        /// </summary>
        [JsonProperty("RecvPacketDropNumber")]
        public long? RecvPacketDropNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "SendPacketLossRate", this.SendPacketLossRate);
            this.SetParamSimple(map, prefix + "SendRetransmissionRate", this.SendRetransmissionRate);
            this.SetParamSimple(map, prefix + "RecvPacketLossRate", this.RecvPacketLossRate);
            this.SetParamSimple(map, prefix + "RecvRetransmissionRate", this.RecvRetransmissionRate);
            this.SetParamSimple(map, prefix + "RTT", this.RTT);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "SendPacketDropNumber", this.SendPacketDropNumber);
            this.SetParamSimple(map, prefix + "RecvPacketDropNumber", this.RecvPacketDropNumber);
        }
    }
}

