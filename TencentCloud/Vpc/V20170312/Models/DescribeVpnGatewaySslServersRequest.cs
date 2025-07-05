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

    public class DescribeVpnGatewaySslServersRequest : AbstractModel
    {
        
        /// <summary>
        /// 偏移量。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 请求对象个数。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// SSL-VPN-SERVER实例ID。形如：vpns-0p4rj60。每次请求的实例的上限为100。参数不支持同时指定SslVpnServerIds和Filters。
        /// </summary>
        [JsonProperty("SslVpnServerIds")]
        public string[] SslVpnServerIds{ get; set; }

        /// <summary>
        /// 过滤条件，参数不支持同时指定SslVpnServerIds和Filters。
        /// <li>vpc-id - String - （过滤条件）VPC实例ID，形如：vpc-f49l6u0z。</li>
        /// <li>vpn-gateway-id - String - （过滤条件）VPN实例ID，形如：vpngw-5aluhh9t。</li>
        /// <li>vpn-gateway-name - String - （过滤条件）VPN实例名称。</li>
        /// <li>ssl-vpn-server-name - String - （过滤条件）SSL-VPN-SERVER实例名称。</li>
        /// <li>ssl-vpn-server-id - String - （过滤条件）SSL-VPN-SERVER实例ID，形如：vpns-xxx。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public FilterObject[] Filters{ get; set; }

        /// <summary>
        /// vpn门户使用。 默认Flase
        /// </summary>
        [JsonProperty("IsVpnPortal")]
        public bool? IsVpnPortal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "SslVpnServerIds.", this.SslVpnServerIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "IsVpnPortal", this.IsVpnPortal);
        }
    }
}

