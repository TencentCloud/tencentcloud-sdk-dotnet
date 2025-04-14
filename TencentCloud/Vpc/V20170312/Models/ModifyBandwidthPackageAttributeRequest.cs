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

    public class ModifyBandwidthPackageAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 带宽包唯一标识ID
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// 带宽包名称
        /// </summary>
        [JsonProperty("BandwidthPackageName")]
        public string BandwidthPackageName{ get; set; }

        /// <summary>
        /// 带宽包计费模式，可选值:
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamSimple(map, prefix + "BandwidthPackageName", this.BandwidthPackageName);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
        }
    }
}

