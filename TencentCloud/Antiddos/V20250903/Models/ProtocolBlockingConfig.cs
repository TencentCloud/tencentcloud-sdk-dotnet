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

    public class ProtocolBlockingConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>TCP 协议封禁。</p><p>枚举值：</p><ul><li>on： 开启</li><li>off： 关闭</li></ul>
        /// </summary>
        [JsonProperty("TCPProtocol")]
        public string TCPProtocol{ get; set; }

        /// <summary>
        /// <p>UDP 协议封禁。</p><p>枚举值：</p><ul><li>on： 开启</li><li>off： 关闭</li></ul>
        /// </summary>
        [JsonProperty("UDPProtocol")]
        public string UDPProtocol{ get; set; }

        /// <summary>
        /// <p>ICMP 协议封禁。</p><p>枚举值：</p><ul><li>on： 开启</li><li>off： 关闭</li></ul>
        /// </summary>
        [JsonProperty("ICMPProtocol")]
        public string ICMPProtocol{ get; set; }

        /// <summary>
        /// <p>其它协议封禁（除 TCP/UDP/ICMP 外的协议）。</p><p>枚举值：</p><ul><li>on： 开启</li><li>off： 关闭</li></ul>
        /// </summary>
        [JsonProperty("OtherProtocol")]
        public string OtherProtocol{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TCPProtocol", this.TCPProtocol);
            this.SetParamSimple(map, prefix + "UDPProtocol", this.UDPProtocol);
            this.SetParamSimple(map, prefix + "ICMPProtocol", this.ICMPProtocol);
            this.SetParamSimple(map, prefix + "OtherProtocol", this.OtherProtocol);
        }
    }
}

