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

    public class DescribeNatGatewayDestinationIpPortTranslationNatRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// NAT网关ID。
        /// </summary>
        [JsonProperty("NatGatewayIds")]
        public string[] NatGatewayIds{ get; set; }

        /// <summary>
        /// 过滤条件:
        /// 参数不支持同时指定NatGatewayIds和Filters。
        /// <li> nat-gateway-id，NAT网关的ID，如`nat-0yi4hekt`</li>
        /// <li> vpc-id，私有网络VPC的ID，如`vpc-0yi4hekt`</li>
        /// <li> public-ip-address， 弹性IP，如`139.199.232.238`。</li>
        /// <li>public-port， 公网端口。</li>
        /// <li>private-ip-address， 内网IP，如`10.0.0.1`。</li>
        /// <li>private-port， 内网端口。</li>
        /// <li>description，规则描述。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NatGatewayIds.", this.NatGatewayIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

