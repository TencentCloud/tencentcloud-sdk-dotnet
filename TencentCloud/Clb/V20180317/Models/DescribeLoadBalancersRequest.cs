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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLoadBalancersRequest : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例ID。实例ID数量上限为20个。
        /// </summary>
        [JsonProperty("LoadBalancerIds")]
        public string[] LoadBalancerIds{ get; set; }

        /// <summary>
        /// 负载均衡实例的网络类型：
        /// OPEN：公网属性， INTERNAL：内网属性。
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// 负载均衡实例的类型。1：通用的负载均衡实例，0：传统型负载均衡实例。如果不传此参数，则查询所有类型的负载均衡实例。
        /// </summary>
        [JsonProperty("Forward")]
        public long? Forward{ get; set; }

        /// <summary>
        /// 负载均衡实例的名称，支持模糊查询。
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// 腾讯云为负载均衡实例分配的域名，支持模糊查询。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 负载均衡实例的 VIP 地址，支持多个。
        /// </summary>
        [JsonProperty("LoadBalancerVips")]
        public string[] LoadBalancerVips{ get; set; }

        /// <summary>
        /// 负载均衡绑定的后端服务的外网 IP，只支持查询云服务器的公网 IP。
        /// </summary>
        [JsonProperty("BackendPublicIps")]
        public string[] BackendPublicIps{ get; set; }

        /// <summary>
        /// 负载均衡绑定的后端服务的内网 IP，只支持查询云服务器的内网 IP。
        /// </summary>
        [JsonProperty("BackendPrivateIps")]
        public string[] BackendPrivateIps{ get; set; }

        /// <summary>
        /// 数据偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回负载均衡实例的数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 排序参数，支持以下字段：
        /// - LoadBalancerName
        /// - CreateTime
        /// - Domain
        /// - LoadBalancerType
        /// 
        /// 默认为 CreateTime。
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 1：倒序，0：顺序，默认为1，按照创建时间倒序。
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// 模糊搜索字段，模糊匹配负载均衡实例的名称、域名、负载均衡实例的 VIP 地址，负载均衡实例ID。
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// 负载均衡实例所属的项目 ID，可以通过[DescribeProject](https://cloud.tencent.com/document/api/651/78725)接口获取，不传默认所有项目。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 负载均衡是否绑定后端服务，0：没有绑定后端服务，1：绑定后端服务，-1：查询全部。
        /// </summary>
        [JsonProperty("WithRs")]
        public long? WithRs{ get; set; }

        /// <summary>
        /// 负载均衡实例所属私有网络唯一ID，如 vpc-bhqkbhdx，可以通过[DescribeVpcs](https://cloud.tencent.com/document/api/215/15778)接口获取。
        /// 查找基础网络类型的负载均衡可传入'0'。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 安全组ID，如 sg-m1cc****，可以通过接口[DescribeSecurityGroups](https://cloud.tencent.com/document/product/215/15808)获取。
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string SecurityGroup{ get; set; }

        /// <summary>
        /// 主可用区ID，如 ："100001" （对应的是广州一区）。可通过[DescribeZones](https://cloud.tencent.com/document/product/213/15707)获取可用区列表。
        /// </summary>
        [JsonProperty("MasterZone")]
        public string MasterZone{ get; set; }

        /// <summary>
        /// 每次请求的`Filters`的上限为10，`Filter.Values`的上限为100。<br/>`Filter.Name`和`Filter.Values`皆为必填项。详细的过滤条件如下：
        /// - charge-type
        /// 按照【实例计费模式】进行过滤。实例计费模式例如：PREPAID。
        /// 类型：String
        /// 必选：否
        /// 可选项：PREPAID(预付费)、POSTPAID_BY_HOUR(后付费)
        /// - internet-charge-type
        /// 按照【网络计费模式】进行过滤。网络计费模式例如：BANDWIDTH_PREPAID。
        /// 类型：String
        /// 必选：否
        /// 可选项：BANDWIDTH_PREPAID(预付费按带宽结算)、 TRAFFIC_POSTPAID_BY_HOUR(流量按小时后付费)、BANDWIDTH_POSTPAID_BY_HOUR(带宽按小时后付费)、BANDWIDTH_PACKAGE(带宽包用户)
        /// - master-zone-id
        /// 按照【CLB主可用区ID】进行过滤。例如：100001（对应的是广州一区）。
        /// 类型：String
        /// 必选：否
        /// 获取方式：[DescribeZones](https://cloud.tencent.com/document/product/213/15707)
        /// - tag-key
        /// 按照【CLB 标签的键】进行过滤，例如：tag-key。
        /// 类型：String
        /// 必选：否
        /// 获取方式：[DescribeTags](https://cloud.tencent.com/document/api/651/35316)
        /// - tag:tag-key
        /// 按照【CLB标签键值】进行过滤，例如：tag-test。
        /// 类型：String
        /// 必选：否
        /// 获取方式：[DescribeTagKeys](https://cloud.tencent.com/document/api/651/35318)
        /// - function-name
        /// 按照【后端绑定SCF云函数的函数名称】进行过滤，例如：helloworld-1744958255。
        /// 类型：String
        /// 必选：否
        /// 获取方式：[ListFunctions](https://cloud.tencent.com/document/api/583/18582)
        /// - vip-isp
        /// 按照【CLB VIP的运营商类型】进行过滤，例如：BGP。
        /// 类型：String
        /// 必选：否
        /// 公网类型可选项：BGP(多线)、CMCC(中国移动)、CTCC(中国电信)、CUCC(中国联通)
        /// 内网类型可选项：INTERNAL(内网)
        /// - sla-type
        /// 按照【CLB 的性能容量型规格】进行过滤，例如：clb.c4.xlarge。
        /// 类型：String
        /// 必选：否
        /// 可选项：clb.c2.medium(标准型)、clb.c3.small(高阶型1)、clb.c3.medium(高阶型2)、clb.c4.small(超强型1)、clb.c4.medium(超强型2)、clb.c4.large(超强型3)、clb.c4.xlarge(超强型4)
        /// 具体规格参数参考：
        /// - exclusive
        /// 按照【独占实例】进行过滤。例如：1，代表筛选独占型实例。
        /// 类型：String
        /// 必选：否
        /// 可选项：0、1
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 选择返回的扩充字段，不指定时，扩充字段默认不返回。详细支持的扩充字段如下：
        /// <li> TargetCount：绑定的后端服务数量</li>
        /// </summary>
        [JsonProperty("AdditionalFields")]
        public string[] AdditionalFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "LoadBalancerIds.", this.LoadBalancerIds);
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamSimple(map, prefix + "Forward", this.Forward);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "LoadBalancerVips.", this.LoadBalancerVips);
            this.SetParamArraySimple(map, prefix + "BackendPublicIps.", this.BackendPublicIps);
            this.SetParamArraySimple(map, prefix + "BackendPrivateIps.", this.BackendPrivateIps);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "WithRs", this.WithRs);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SecurityGroup", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "MasterZone", this.MasterZone);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "AdditionalFields.", this.AdditionalFields);
        }
    }
}

