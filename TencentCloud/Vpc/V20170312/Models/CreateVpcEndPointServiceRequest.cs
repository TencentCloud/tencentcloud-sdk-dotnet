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

    public class CreateVpcEndPointServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC实例ID。可通过[DescribeVpcs](https://cloud.tencent.com/document/product/1108/43663)接口获取。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 终端节点服务名称。
        /// </summary>
        [JsonProperty("EndPointServiceName")]
        public string EndPointServiceName{ get; set; }

        /// <summary>
        /// 是否自动接受。
        /// </summary>
        [JsonProperty("AutoAcceptFlag")]
        public bool? AutoAcceptFlag{ get; set; }

        /// <summary>
        /// 后端服务ID，比如lb-p1hiksdg。CLB可通过[DescribeLoadBalancers](https://cloud.tencent.com/document/product/1108/48459)接口获取；CDB可通过[DescribeDBInstances](https://cloud.tencent.com/document/api/240/38568)接口获取；CRS可通过[DescribeInstances](https://cloud.tencent.com/document/product/239/20018)接口获取；GWLB可通过[DescribeGatewayLoadBalancers](https://cloud.tencent.com/document/product/1782/111683)接口获取。
        /// </summary>
        [JsonProperty("ServiceInstanceId")]
        public string ServiceInstanceId{ get; set; }

        /// <summary>
        /// ~~是否是PassService类型。该字段已废弃，请不要使用该字段。~~
        /// </summary>
        [JsonProperty("IsPassService")]
        public bool? IsPassService{ get; set; }

        /// <summary>
        /// 挂载的PAAS服务类型，CLB（负载均衡），CDB（云数据库 MySQL），CRS（云数据库 Redis），GWLB（网关负载均衡）。不填默认挂载为CLB。
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 指定绑定的标签列表，例如：[{"Key": "city", "Value": "shanghai"}]。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 协议类型，支持 Ipv4，Ipv6，默认 Ipv4。
        /// </summary>
        [JsonProperty("IpAddressType")]
        public string IpAddressType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "EndPointServiceName", this.EndPointServiceName);
            this.SetParamSimple(map, prefix + "AutoAcceptFlag", this.AutoAcceptFlag);
            this.SetParamSimple(map, prefix + "ServiceInstanceId", this.ServiceInstanceId);
            this.SetParamSimple(map, prefix + "IsPassService", this.IsPassService);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "IpAddressType", this.IpAddressType);
        }
    }
}

