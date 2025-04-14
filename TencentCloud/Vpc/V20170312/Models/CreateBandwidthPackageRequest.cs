/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class CreateBandwidthPackageRequest : AbstractModel
    {
        
        /// <summary>
        /// 带宽包类型, 默认值: BGP, 可选值:
        /// <li>BGP: 普通BGP共享带宽包</li>
        /// <li>HIGH_QUALITY_BGP: 精品BGP共享带宽包</li>
        /// <li>SINGLEISP_CMCC: 中国移动共享带宽包</li>
        /// <li>SINGLEISP_CTCC: 中国电信共享带宽包</li>
        /// <li>SINGLEISP_CUCC: 中国联通共享带宽包</li>
        /// 注意：仅部分地域支持三网带宽包和精品BGP带宽包。
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// 带宽包计费类型, 默认为: ENHANCED95_POSTPAID_BY_MONTH, 可选值:
        /// <li>ENHANCED95_POSTPAID_BY_MONTH: 后付费-增强型95计费</li>
        /// <li>PRIMARY_TRAFFIC_POSTPAID_BY_HOUR: 后付费-按主流量计费</li>
        /// <li>BANDWIDTH_POSTPAID_BY_DAY: 常规BGP-后付费-按带宽计费</li>
        /// <li>FIXED_PREPAID_BY_MONTH: 常规BGP-预付费</li>
        /// <li>PEAK_BANDWIDTH_POSTPAID_BY_DAY: 静态单线-后付费-按日结算</li>
        /// <li>TOP5_POSTPAID_BY_MONTH: 后付费-TOP5计费，如需使用，请提交工单申请</li>
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 带宽包名称。名称长度小于60，只包含数字、字母和下划线。
        /// </summary>
        [JsonProperty("BandwidthPackageName")]
        public string BandwidthPackageName{ get; set; }

        /// <summary>
        /// 带宽包数量(传统账户类型只能填1), 标准账户类型取值范围为1~20。默认为1。
        /// </summary>
        [JsonProperty("BandwidthPackageCount")]
        public ulong? BandwidthPackageCount{ get; set; }

        /// <summary>
        /// 带宽包限速大小。单位：Mbps，-1表示不限速。带宽包计费类型对应的带宽上下限可参考：[BandwidthRange](https://cloud.tencent.com/document/api/215/15824#BandwidthRange)
        /// </summary>
        [JsonProperty("InternetMaxBandwidth")]
        public long? InternetMaxBandwidth{ get; set; }

        /// <summary>
        /// 需要关联的标签列表。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 带宽包协议类型。当前支持'ipv4'和'ipv6'协议带宽包，默认值是'ipv4'。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 预付费包月带宽包的购买时长，单位: 月，取值范围: 1~60。预付费计费类型必传。
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// 网络出口，默认值：center_egress1，其它可选值：center_egress2、center_egress3。
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "BandwidthPackageName", this.BandwidthPackageName);
            this.SetParamSimple(map, prefix + "BandwidthPackageCount", this.BandwidthPackageCount);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidth", this.InternetMaxBandwidth);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "Egress", this.Egress);
        }
    }
}

