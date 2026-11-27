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

    public class ProtectionPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>默认防护配置。</p>
        /// </summary>
        [JsonProperty("DefaultProtection")]
        public DefaultProtectionConfig DefaultProtection{ get; set; }

        /// <summary>
        /// <p>IP 黑白名单规则列表。</p>
        /// </summary>
        [JsonProperty("IPACLRules")]
        public IPACLRules IPACLRules{ get; set; }

        /// <summary>
        /// <p>端口过滤规则列表。</p>
        /// </summary>
        [JsonProperty("PortACLRules")]
        public PortACLRules PortACLRules{ get; set; }

        /// <summary>
        /// <p>限速规则列表。</p>
        /// </summary>
        [JsonProperty("SpeedLimitRules")]
        public SpeedLimitRules SpeedLimitRules{ get; set; }

        /// <summary>
        /// <p>包特征过滤规则列表。</p>
        /// </summary>
        [JsonProperty("PacketFilterRules")]
        public PacketFilterRules PacketFilterRules{ get; set; }

        /// <summary>
        /// <p>区域封禁配置。</p>
        /// </summary>
        [JsonProperty("GeoBlocking")]
        public GeoBlockingConfig GeoBlocking{ get; set; }

        /// <summary>
        /// <p>协议封禁配置。</p>
        /// </summary>
        [JsonProperty("ProtocolBlocking")]
        public ProtocolBlockingConfig ProtocolBlocking{ get; set; }

        /// <summary>
        /// <p>连接类攻击防护配置。</p>
        /// </summary>
        [JsonProperty("ConnectionProtection")]
        public ConnectionProtectionConfig ConnectionProtection{ get; set; }

        /// <summary>
        /// <p>流量签名配置。</p>
        /// </summary>
        [JsonProperty("TrafficSignature")]
        public TrafficSignatureConfig TrafficSignature{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DefaultProtection.", this.DefaultProtection);
            this.SetParamObj(map, prefix + "IPACLRules.", this.IPACLRules);
            this.SetParamObj(map, prefix + "PortACLRules.", this.PortACLRules);
            this.SetParamObj(map, prefix + "SpeedLimitRules.", this.SpeedLimitRules);
            this.SetParamObj(map, prefix + "PacketFilterRules.", this.PacketFilterRules);
            this.SetParamObj(map, prefix + "GeoBlocking.", this.GeoBlocking);
            this.SetParamObj(map, prefix + "ProtocolBlocking.", this.ProtocolBlocking);
            this.SetParamObj(map, prefix + "ConnectionProtection.", this.ConnectionProtection);
            this.SetParamObj(map, prefix + "TrafficSignature.", this.TrafficSignature);
        }
    }
}

