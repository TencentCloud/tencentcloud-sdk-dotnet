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

    public class BandwidthPackage : AbstractModel
    {
        
        /// <summary>
        /// 带宽包唯一标识Id
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// 带宽包类型，包括：
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
        /// 带宽包计费类型, 包括:
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
        /// 带宽包名称
        /// </summary>
        [JsonProperty("BandwidthPackageName")]
        public string BandwidthPackageName{ get; set; }

        /// <summary>
        /// 带宽包创建时间。按照`ISO8601`标准表示，并且使用`UTC`时间。格式为：`YYYY-MM-DDThh:mm:ssZ`。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 带宽包状态，包括'CREATING','CREATED','DELETING','DELETED'
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 带宽包资源信息
        /// </summary>
        [JsonProperty("ResourceSet")]
        public Resource[] ResourceSet{ get; set; }

        /// <summary>
        /// 带宽包限速大小。单位：Mbps，-1表示不限速。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 网络出口
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }

        /// <summary>
        /// 带宽包到期时间，只有预付费会返回，按量计费返回为null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "BandwidthPackageName", this.BandwidthPackageName);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "ResourceSet.", this.ResourceSet);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Egress", this.Egress);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
        }
    }
}

