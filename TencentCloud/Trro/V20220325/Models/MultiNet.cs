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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MultiNet : AbstractModel
    {
        
        /// <summary>
        /// 网卡序号
        /// </summary>
        [JsonProperty("NetId")]
        public long? NetId{ get; set; }

        /// <summary>
        /// 网卡IP
        /// </summary>
        [JsonProperty("NetIp")]
        public string NetIp{ get; set; }

        /// <summary>
        /// 时延，单位ms
        /// </summary>
        [JsonProperty("Rtt")]
        public long?[] Rtt{ get; set; }

        /// <summary>
        /// 丢包率，单位%
        /// </summary>
        [JsonProperty("Lost")]
        public long?[] Lost{ get; set; }

        /// <summary>
        /// 发送bps，单位kbps
        /// </summary>
        [JsonProperty("SendBps")]
        public long?[] SendBps{ get; set; }

        /// <summary>
        /// 接收bps，单位kbps
        /// </summary>
        [JsonProperty("RecvBps")]
        public long?[] RecvBps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetId", this.NetId);
            this.SetParamSimple(map, prefix + "NetIp", this.NetIp);
            this.SetParamArraySimple(map, prefix + "Rtt.", this.Rtt);
            this.SetParamArraySimple(map, prefix + "Lost.", this.Lost);
            this.SetParamArraySimple(map, prefix + "SendBps.", this.SendBps);
            this.SetParamArraySimple(map, prefix + "RecvBps.", this.RecvBps);
        }
    }
}

