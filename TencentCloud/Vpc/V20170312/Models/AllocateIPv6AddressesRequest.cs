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

    public class AllocateIPv6AddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// EIP名称，用于申请EIP时用户自定义该EIP的个性化名称。长度上限为128个字符，允许使用大小写字母、汉字、数字、连字符"-"和下划线"_"，不能包含空格。
        /// 默认值：未命名
        /// </summary>
        [JsonProperty("AddressName")]
        public string AddressName{ get; set; }

        /// <summary>
        /// 弹性公网IPv6类型，可选值：
        /// 
        /// - EIPv6：弹性公网IPv6
        /// - HighQualityEIPv6：精品BGP线路弹性公网IPv6
        /// 注意：弹性公网IPv6产品需开白才能使用，其中精品BGP线路仅在中国香港支持。
        /// 
        /// 默认值：EIPv6
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// 申请的弹性公网IPv6数量。单次最多可以申请20个弹性公网IPv6实例，总配额请参见[弹性公网 IPv6 配额说明](https://cloud.tencent.com/document/product/1142/38369)。
        /// 
        /// 默认值：1
        /// </summary>
        [JsonProperty("AddressCount")]
        public long? AddressCount{ get; set; }

        /// <summary>
        /// 弹性公网IPv6计费方式，可选值：
        /// 
        /// - BANDWIDTH_PACKAGE：[共享带宽包](https://cloud.tencent.com/document/product/684/15255)付费
        /// - TRAFFIC_POSTPAID_BY_HOUR：流量按小时后付费
        /// 
        /// 默认值：TRAFFIC_POSTPAID_BY_HOUR
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// 弹性公网IPv6线路类型，默认值：BGP。
        /// 
        /// 已开通静态单线IP白名单的用户，可选值：
        /// - CMCC：中国移动
        /// - CTCC：中国电信
        /// - CUCC：中国联通
        /// 注意：仅部分地域支持静态单线IP。具体请以控制台购买页展示为准。
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// 弹性公网IPv6带宽上限，单位：Mbps。
        /// 
        /// 可选值范围取决于EIP计费方式：
        /// 
        /// - BANDWIDTH_PACKAGE（共享带宽包付费）：1 Mbps 至 2000 Mbps
        /// - TRAFFIC_POSTPAID_BY_HOUR（流量按小时后付费）：1 Mbps 至 100 Mbps
        /// 
        /// 默认值：1
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 带宽包唯一ID参数。可以使用[DescribeBandwidthPackages](https://cloud.tencent.com/document/product/215/19209)接口查询BandwidthPackageId。
        /// 设定该参数且InternetChargeType为BANDWIDTH_PACKAGE，则表示创建的EIP加入该BGP带宽包并采用带宽包计费。
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// 需要关联的标签列表。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 弹性公网IPv6网络出口，可选值：
        /// 
        /// - CENTER_EGRESS_1：中心出口一
        /// - CENTER_EGRESS_2：中心出口二
        /// 注意：不同地域支持的线路类型、网络出口略有差异，请以控制台展示为准。
        /// 
        /// 默认值：CENTER_EGRESS_1
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressName", this.AddressName);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamSimple(map, prefix + "AddressCount", this.AddressCount);
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "InternetServiceProvider", this.InternetServiceProvider);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Egress", this.Egress);
        }
    }
}

