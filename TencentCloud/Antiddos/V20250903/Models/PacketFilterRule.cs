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

    public class PacketFilterRule : AbstractModel
    {
        
        /// <summary>
        /// <p>匹配后执行的动作。</p><p>枚举值：</p><ul><li>drop： 丢弃。</li><li>allow： 放行。</li><li>drop_and_block： 丢弃并拉黑。</li><li>forward： 继续防护，即继续执行下一个防护子策略，而非特征过滤内的其他规则。</li></ul>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>协议类型。</p><p>枚举值：</p><ul><li>tcp： TCP 协议。</li><li>udp： UDP 协议。</li><li>all： 所有协议。</li></ul>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>报文长度范围。</p>
        /// </summary>
        [JsonProperty("PacketSizeRange")]
        public SizeRange PacketSizeRange{ get; set; }

        /// <summary>
        /// <p>源端口范围。</p>
        /// </summary>
        [JsonProperty("SourcePortRange")]
        public PortRange SourcePortRange{ get; set; }

        /// <summary>
        /// <p>目的端口范围。</p>
        /// </summary>
        [JsonProperty("DestinationPortRange")]
        public PortRange DestinationPortRange{ get; set; }

        /// <summary>
        /// <p>报文匹配条件列表。</p>
        /// </summary>
        [JsonProperty("PacketFilterConditions")]
        public PacketFilterCondition[] PacketFilterConditions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "PacketSizeRange.", this.PacketSizeRange);
            this.SetParamObj(map, prefix + "SourcePortRange.", this.SourcePortRange);
            this.SetParamObj(map, prefix + "DestinationPortRange.", this.DestinationPortRange);
            this.SetParamArrayObj(map, prefix + "PacketFilterConditions.", this.PacketFilterConditions);
        }
    }
}

