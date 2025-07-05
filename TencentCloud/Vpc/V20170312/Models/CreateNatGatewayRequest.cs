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

    public class CreateNatGatewayRequest : AbstractModel
    {
        
        /// <summary>
        /// NAT网关名称
        /// </summary>
        [JsonProperty("NatGatewayName")]
        public string NatGatewayName{ get; set; }

        /// <summary>
        /// VPC实例ID。可通过DescribeVpcs接口返回值中的VpcId获取。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// NAT网关最大外网出带宽(单位：Mbps)，支持的参数值：20, 50, 100, 200, 500, 1000, 2000, 5000，默认: 100Mbps。  当以下NatProductVersion参数值为2即标准型时，此参数无需填写，默认为5000Mbps。
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// NAT网关并发连接数上限，支持参数值：1000000、3000000、10000000，默认值为100000。  当以下NatProductVersion参数值为2即标准型时，此参数无需填写，默认为2000000。
        /// </summary>
        [JsonProperty("MaxConcurrentConnection")]
        public ulong? MaxConcurrentConnection{ get; set; }

        /// <summary>
        /// 新建弹性公网IP个数，系统会按您的要求创建对应数量的弹性公网IP，其中AddressCount和PublicAddresses两个参数至少填写一个。
        /// </summary>
        [JsonProperty("AddressCount")]
        public ulong? AddressCount{ get; set; }

        /// <summary>
        /// 绑定NAT网关的已有弹性公网IP数组，其中AddressCount和PublicAddresses两个参数至少填写一个。 示例值：["139.199.232.119"]
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string[] PublicIpAddresses{ get; set; }

        /// <summary>
        /// 可用区，形如：`ap-guangzhou-1`。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 指定绑定的标签列表，例如：[{"Key": "city", "Value": "shanghai"}]
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// NAT网关所属子网，已废弃
        /// </summary>
        [JsonProperty("SubnetId")]
        [System.Obsolete]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 绑定NAT网关的弹性公网IP带宽值（单位：Mbps）。不填写此参数时：则该参数默认为弹性公网IP的带宽值，部分用户默认为该用户类型的弹性公网IP的带宽上限。
        /// </summary>
        [JsonProperty("StockPublicIpAddressesBandwidthOut")]
        public ulong? StockPublicIpAddressesBandwidthOut{ get; set; }

        /// <summary>
        /// 需要申请公网IP带宽大小（单位Mbps），默认为当前用户类型所能使用的最大值。
        /// </summary>
        [JsonProperty("PublicIpAddressesBandwidthOut")]
        public ulong? PublicIpAddressesBandwidthOut{ get; set; }

        /// <summary>
        /// 公网IP是否强制与NAT网关来自同可用区，true表示需要与NAT网关同可用区；false表示可与NAT网关不是同一个可用区。此参数只有当参数Zone存在时才能生效。
        /// </summary>
        [JsonProperty("PublicIpFromSameZone")]
        public bool? PublicIpFromSameZone{ get; set; }

        /// <summary>
        /// NAT网关类型，1表示传统型NAT网关，2表示标准型NAT网关，默认值是1。
        /// </summary>
        [JsonProperty("NatProductVersion")]
        public ulong? NatProductVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatGatewayName", this.NatGatewayName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "MaxConcurrentConnection", this.MaxConcurrentConnection);
            this.SetParamSimple(map, prefix + "AddressCount", this.AddressCount);
            this.SetParamArraySimple(map, prefix + "PublicIpAddresses.", this.PublicIpAddresses);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "StockPublicIpAddressesBandwidthOut", this.StockPublicIpAddressesBandwidthOut);
            this.SetParamSimple(map, prefix + "PublicIpAddressesBandwidthOut", this.PublicIpAddressesBandwidthOut);
            this.SetParamSimple(map, prefix + "PublicIpFromSameZone", this.PublicIpFromSameZone);
            this.SetParamSimple(map, prefix + "NatProductVersion", this.NatProductVersion);
        }
    }
}

