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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClusterEndpointRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>集群端口所在的子网ID  (仅在开启非外网访问时需要填，必须为集群所在VPC内的子网)。获取方式：https://cloud.tencent.com/document/product/215/15784</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>是否为外网访问（TRUE 外网访问 FALSE 内网访问，默认值： FALSE）</p>
        /// </summary>
        [JsonProperty("IsExtranet")]
        public bool? IsExtranet{ get; set; }

        /// <summary>
        /// <p>设置域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>使用的安全组（开启内外网访问且不使用已有clb时可传，内网访问需要先找clb侧加白使用）。获取方式：https://cloud.tencent.com/document/api/215/15808</p>
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string SecurityGroup{ get; set; }

        /// <summary>
        /// <p>创建lb参数，只有外网访问需要设置，是一个json格式化后的字符串：{&quot;InternetAccessible&quot;:{&quot;InternetChargeType&quot;:&quot;TRAFFIC_POSTPAID_BY_HOUR&quot;,&quot;InternetMaxBandwidthOut&quot;:200},&quot;VipIsp&quot;:&quot;&quot;,&quot;BandwidthPackageId&quot;:&quot;&quot;}。<br>各个参数意义：<br>InternetAccessible.InternetChargeType含义：TRAFFIC_POSTPAID_BY_HOUR按流量按小时后计费;BANDWIDTH_POSTPAID_BY_HOUR 按带宽按小时后计费;InternetAccessible.BANDWIDTH_PACKAGE 按带宽包计费。<br>InternetMaxBandwidthOut含义：最大出带宽，单位Mbps，范围支持0到2048，默认值10。<br>VipIsp含义：CMCC | CTCC | CUCC，分别对应 移动 | 电信 | 联通，如果不指定本参数，则默认使用BGP。可通过 DescribeSingleIsp 接口查询一个地域所支持的Isp。如果指定运营商，则网络计费式只能使用按带宽包计费BANDWIDTH_PACKAGE。<br>BandwidthPackageId含义：带宽包ID，指定此参数时，网络计费方式InternetAccessible.InternetChargeType只支持按带宽包计费BANDWIDTH_PACKAGE。</p>
        /// </summary>
        [JsonProperty("ExtensiveParameters")]
        public string ExtensiveParameters{ get; set; }

        /// <summary>
        /// <p>使用已有clb开启内网或外网访问</p>
        /// </summary>
        [JsonProperty("ExistedLoadBalancerId")]
        public string ExistedLoadBalancerId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "IsExtranet", this.IsExtranet);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "SecurityGroup", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "ExtensiveParameters", this.ExtensiveParameters);
            this.SetParamSimple(map, prefix + "ExistedLoadBalancerId", this.ExistedLoadBalancerId);
        }
    }
}

