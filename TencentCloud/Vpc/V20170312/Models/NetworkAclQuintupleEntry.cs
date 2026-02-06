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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkAclQuintupleEntry : AbstractModel
    {
        
        /// <summary>
        /// 协议, 取值: TCP,UDP, ICMP, ALL。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 源端口(all, 单个port,  range)。当Protocol为ALL或ICMP时，不能指定Port。
        /// </summary>
        [JsonProperty("SourcePort")]
        public string SourcePort{ get; set; }

        /// <summary>
        /// 源CIDR。
        /// </summary>
        [JsonProperty("SourceCidr")]
        public string SourceCidr{ get; set; }

        /// <summary>
        /// 目的端口(all, 单个port,  range)。当Protocol为ALL或ICMP时，不能指定Port。
        /// </summary>
        [JsonProperty("DestinationPort")]
        public string DestinationPort{ get; set; }

        /// <summary>
        /// 目的CIDR。
        /// </summary>
        [JsonProperty("DestinationCidr")]
        public string DestinationCidr{ get; set; }

        /// <summary>
        /// 动作，ACCEPT 或 DROP。
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 网络ACL条目唯一ID。
        /// </summary>
        [JsonProperty("NetworkAclQuintupleEntryId")]
        public string NetworkAclQuintupleEntryId{ get; set; }

        /// <summary>
        /// 优先级，从1开始。
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 创建时间，用于DescribeNetworkAclQuintupleEntries的出参。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 方向，INGRESS或EGRESS，用于DescribeNetworkAclQuintupleEntries的出参。
        /// </summary>
        [JsonProperty("NetworkAclDirection")]
        public string NetworkAclDirection{ get; set; }

        /// <summary>
        /// IPv6源CIDR。
        /// </summary>
        [JsonProperty("SourceIPv6Cidr")]
        public string SourceIPv6Cidr{ get; set; }

        /// <summary>
        /// IPv6目的CIDR。
        /// </summary>
        [JsonProperty("DestinationIPv6Cidr")]
        public string DestinationIPv6Cidr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SourcePort", this.SourcePort);
            this.SetParamSimple(map, prefix + "SourceCidr", this.SourceCidr);
            this.SetParamSimple(map, prefix + "DestinationPort", this.DestinationPort);
            this.SetParamSimple(map, prefix + "DestinationCidr", this.DestinationCidr);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "NetworkAclQuintupleEntryId", this.NetworkAclQuintupleEntryId);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "NetworkAclDirection", this.NetworkAclDirection);
            this.SetParamSimple(map, prefix + "SourceIPv6Cidr", this.SourceIPv6Cidr);
            this.SetParamSimple(map, prefix + "DestinationIPv6Cidr", this.DestinationIPv6Cidr);
        }
    }
}

