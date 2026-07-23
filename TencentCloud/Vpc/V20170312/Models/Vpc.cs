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

    public class Vpc : AbstractModel
    {
        
        /// <summary>
        /// <p><code>VPC</code>名称。</p>
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// <p><code>VPC</code>实例<code>ID</code>，例如：vpc-azd4dt1c。</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p><code>VPC</code>的<code>IPv4</code> <code>CIDR</code>。</p>
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// <p>是否默认<code>VPC</code>。</p>
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// <p>是否开启组播。</p>
        /// </summary>
        [JsonProperty("EnableMulticast")]
        public bool? EnableMulticast{ get; set; }

        /// <summary>
        /// <p>创建时间。</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p><code>DNS</code>列表。</p>
        /// </summary>
        [JsonProperty("DnsServerSet")]
        public string[] DnsServerSet{ get; set; }

        /// <summary>
        /// <p><code>DHCP</code>域名选项值。</p>
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// <p><code>DHCP</code>选项集<code>ID</code>。</p>
        /// </summary>
        [JsonProperty("DhcpOptionsId")]
        public string DhcpOptionsId{ get; set; }

        /// <summary>
        /// <p>是否开启<code>DHCP</code>。</p>
        /// </summary>
        [JsonProperty("EnableDhcp")]
        public bool? EnableDhcp{ get; set; }

        /// <summary>
        /// <p><code>VPC</code>的<code>IPv6</code> <code>CIDR</code>。</p>
        /// </summary>
        [JsonProperty("Ipv6CidrBlock")]
        public string Ipv6CidrBlock{ get; set; }

        /// <summary>
        /// <p>标签键值对</p>
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// <p>辅助CIDR</p>
        /// </summary>
        [JsonProperty("AssistantCidrSet")]
        public AssistantCidr[] AssistantCidrSet{ get; set; }

        /// <summary>
        /// <p>vpc关联云联网时路由发布策略， true：开启cidr路由发布，false：开启subnet子网路由发布。创建vpc时默认为子网路由发布，当选择cidr路由发布时,请通过工单加入白名单</p>
        /// </summary>
        [JsonProperty("EnableRouteVpcPublish")]
        public bool? EnableRouteVpcPublish{ get; set; }

        /// <summary>
        /// <p>返回多运营商IPv6 Cidr Block</p>
        /// </summary>
        [JsonProperty("Ipv6CidrBlockSet")]
        public ISPIPv6CidrBlock[] Ipv6CidrBlockSet{ get; set; }

        /// <summary>
        /// <p>vpc关联云联网时IPv6类型路由发布策略， true：开启cidr路由发布，false：开启subnet子网路由发布。创建vpc时默认为子网路由发布，当选择cidr路由发布时，请通过工单加入白名单。</p>
        /// </summary>
        [JsonProperty("EnableRouteVpcPublishIpv6")]
        public bool? EnableRouteVpcPublishIpv6{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "EnableMulticast", this.EnableMulticast);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArraySimple(map, prefix + "DnsServerSet.", this.DnsServerSet);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "DhcpOptionsId", this.DhcpOptionsId);
            this.SetParamSimple(map, prefix + "EnableDhcp", this.EnableDhcp);
            this.SetParamSimple(map, prefix + "Ipv6CidrBlock", this.Ipv6CidrBlock);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamArrayObj(map, prefix + "AssistantCidrSet.", this.AssistantCidrSet);
            this.SetParamSimple(map, prefix + "EnableRouteVpcPublish", this.EnableRouteVpcPublish);
            this.SetParamArrayObj(map, prefix + "Ipv6CidrBlockSet.", this.Ipv6CidrBlockSet);
            this.SetParamSimple(map, prefix + "EnableRouteVpcPublishIpv6", this.EnableRouteVpcPublishIpv6);
        }
    }
}

