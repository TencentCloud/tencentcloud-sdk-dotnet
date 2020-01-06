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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetDetectIpState : AbstractModel
    {
        
        /// <summary>
        /// 探测目的IPv4地址。
        /// </summary>
        [JsonProperty("DetectDestinationIp")]
        public string DetectDestinationIp{ get; set; }

        /// <summary>
        /// 探测结果。
        /// 0：成功；
        /// -1：查询不到路由丢包；
        /// -2：外出ACL丢包；
        /// -3：IN ACL丢包；
        /// -4：其他错误；
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// 时延，单位毫秒
        /// </summary>
        [JsonProperty("Delay")]
        public ulong? Delay{ get; set; }

        /// <summary>
        /// 丢包率
        /// </summary>
        [JsonProperty("PacketLossRate")]
        public ulong? PacketLossRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DetectDestinationIp", this.DetectDestinationIp);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Delay", this.Delay);
            this.SetParamSimple(map, prefix + "PacketLossRate", this.PacketLossRate);
        }
    }
}

