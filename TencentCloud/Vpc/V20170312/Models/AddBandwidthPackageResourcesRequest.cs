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

    public class AddBandwidthPackageResourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源唯一ID，当前支持EIP资源和LB资源，形如'eip-xxxx', 'lb-xxxx'。EIP资源列表可通过[DescribeAddresses](https://cloud.tencent.com/document/product/215/16702)接口获取，LB资源列表可通过[DescribeLoadBalancers](https://cloud.tencent.com/document/api/214/30685)接口获取。
        /// </summary>
        [JsonProperty("ResourceIds")]
        public string[] ResourceIds{ get; set; }

        /// <summary>
        /// 带宽包唯一标识ID，形如'bwp-xxxx'，可以使用[DescribeBandwidthPackages](https://cloud.tencent.com/document/product/215/19209)接口查询BandwidthPackageId。
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// 带宽包类型，可选值：
        /// <li>BGP: 普通BGP共享带宽包</li>
        /// <li>HIGH_QUALITY_BGP: 精品BGP共享带宽包</li>
        /// <li>ANYCAST：公网加速带宽包</li>
        /// <li>SINGLEISP_CMCC: 中国移动共享带宽包</li>
        /// <li>SINGLEISP_CTCC: 中国电信共享带宽包</li>
        /// <li>SINGLEISP_CUCC: 中国联通共享带宽包</li>
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// 资源类型，可选值：
        /// <li>Address：弹性公网IP</li>
        /// <li>LoadBalance：负载均衡</li>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 带宽包协议类型。当前支持'ipv4'和'ipv6'协议类型。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 用于带宽包内添加IP资源时指定IP带宽值。<p>说明：当前功能处于内测中，如需使用，请提交[工单申请](https://console.cloud.tencent.com/workorder/category)。</p>
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ResourceIds.", this.ResourceIds);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
        }
    }
}

