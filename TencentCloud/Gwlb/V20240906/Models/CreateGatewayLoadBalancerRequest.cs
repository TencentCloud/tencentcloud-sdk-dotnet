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

namespace TencentCloud.Gwlb.V20240906.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateGatewayLoadBalancerRequest : AbstractModel
    {
        
        /// <summary>
        /// 网关负载均衡后端目标设备所属的私有网络 ID，如vpc-azd4dt1c，可以通过 [DescribeVpcs](https://cloud.tencent.com/document/product/215/15778)  接口获取。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 网关负载均衡后端目标设备所属的私有网络的子网ID。可通过[DescribeSubnets](https://cloud.tencent.com/document/product/215/15784)接口获取。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 网关负载均衡实例名称。可支持输入1-60个字符。不填写时默认自动生成。
        /// </summary>
        [JsonProperty("LoadBalancerName")]
        public string LoadBalancerName{ get; set; }

        /// <summary>
        /// 创建网关负载均衡的个数，默认值为 1。批量创建数量最大支持10个。
        /// </summary>
        [JsonProperty("Number")]
        public ulong? Number{ get; set; }

        /// <summary>
        /// 购买网关负载均衡的同时，给负载均衡打上标签，最大支持20个标签键值对。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// 网关负载均衡实例计费类型，当前只支持传POSTPAID_BY_HOUR（按量计费），默认是POSTPAID_BY_HOUR。
        /// </summary>
        [JsonProperty("LBChargeType")]
        public string LBChargeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "LoadBalancerName", this.LoadBalancerName);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "LBChargeType", this.LBChargeType);
        }
    }
}

