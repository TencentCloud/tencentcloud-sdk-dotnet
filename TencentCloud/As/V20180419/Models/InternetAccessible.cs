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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InternetAccessible : AbstractModel
    {
        
        /// <summary>
        /// 网络计费类型。取值范围：<li>BANDWIDTH_PREPAID：预付费按带宽结算</li><li>TRAFFIC_POSTPAID_BY_HOUR：流量按小时后付费</li><li>BANDWIDTH_POSTPAID_BY_HOUR：带宽按小时后付费</li><li>BANDWIDTH_PACKAGE：带宽包用户</li>默认取值：TRAFFIC_POSTPAID_BY_HOUR。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// 公网出带宽上限，单位：Mbps。默认值：0Mbps。不同机型带宽上限范围不一致，具体限制详见[购买网络带宽](https://cloud.tencent.com/document/product/213/509)。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 是否分配公网IP。取值范围：<li>TRUE：表示分配公网IP</li><li>FALSE：表示不分配公网IP</li>当公网带宽大于0Mbps时，可自由选择开通与否，默认开通公网IP；当公网带宽为0，则不允许分配公网IP。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicIpAssigned")]
        public bool? PublicIpAssigned{ get; set; }

        /// <summary>
        /// 带宽包ID。可通过[DescribeBandwidthPackages](https://cloud.tencent.com/document/api/215/19209)接口返回值中的`BandwidthPackageId`获取。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// 线路类型。各种线路类型详情可参考：[EIP 的 IP 地址类型](https://cloud.tencent.com/document/product/1199/41646)。默认值：BGP。
        /// 
        /// <li>BGP：常规 BGP 线路</li>
        /// 已开通静态单线IP白名单的用户，可选值：
        /// 
        /// <li>CMCC：中国移动</li>
        /// <li>CTCC：中国电信</li>
        /// <li>CUCC：中国联通</li>
        /// 注意：仅部分地域支持静态单线IP。
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// 公网 IP 类型。
        /// 
        /// <li> WanIP：普通公网IP。</li>
        /// <li> HighQualityEIP：精品 IP。仅新加坡和中国香港支持精品IP。</li>
        /// <li> AntiDDoSEIP：高防 IP。仅部分地域支持高防IP，详情可见[弹性公网IP产品概述](https://cloud.tencent.com/document/product/1199/41646) 。  </li> 
        /// 如需为资源分配公网IPv4地址，请指定公网IPv4地址类型。
        /// 
        /// 精品IP 高防IP功能仅部分地区灰度开放，如需使用[请提交工单咨询](https://console.cloud.tencent.com/workorder/category)
        /// </summary>
        [JsonProperty("IPv4AddressType")]
        public string IPv4AddressType{ get; set; }

        /// <summary>
        /// 高防包唯一ID，申请高防IP时，该字段必传。
        /// </summary>
        [JsonProperty("AntiDDoSPackageId")]
        public string AntiDDoSPackageId{ get; set; }

        /// <summary>
        /// 实例销毁时是否一并销毁绑定的弹性IP。
        /// 
        /// 取值范围：
        /// <li>TRUE：表示保留EIP</li>
        /// <li>FALSE：表示不保留</li>
        /// 请注意，当IPv4AddressType字段指定EIP类型时，默认不保留EIP。WanIP不受此字段影响始终随实例销毁。
        /// 变更配置此字段，已绑定伸缩组会立刻生效。
        /// </summary>
        [JsonProperty("IsKeepEIP")]
        public bool? IsKeepEIP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "PublicIpAssigned", this.PublicIpAssigned);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamSimple(map, prefix + "InternetServiceProvider", this.InternetServiceProvider);
            this.SetParamSimple(map, prefix + "IPv4AddressType", this.IPv4AddressType);
            this.SetParamSimple(map, prefix + "AntiDDoSPackageId", this.AntiDDoSPackageId);
            this.SetParamSimple(map, prefix + "IsKeepEIP", this.IsKeepEIP);
        }
    }
}

