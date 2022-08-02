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

    public class DescribeNetworkAclQuintupleEntriesRequest : AbstractModel
    {
        
        /// <summary>
        /// 网络ACL实例ID。形如：acl-12345678。
        /// </summary>
        [JsonProperty("NetworkAclId")]
        public string NetworkAclId{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最小值为1，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 过滤条件，参数不支持同时指定`HaVipIds`和`Filters`。
        /// <li>protocol - String - 协议，形如：`TCP`。</li>
        /// <li>description - String - 描述。</li>
        /// <li>destination-cidr - String - 目的CIDR， 形如：'192.168.0.0/24'。</li>
        /// <li>source-cidr- String - 源CIDR， 形如：'192.168.0.0/24'。</li>
        /// <li>action - String - 动作，形如ACCEPT或DROP。</li>
        /// <li>network-acl-quintuple-entry-id - String - 五元组唯一ID，形如：'acli45-ahnu4rv5'。</li>
        /// <li>network-acl-direction - String - 方向，形如：'INGRESS'或'EGRESS'。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkAclId", this.NetworkAclId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

