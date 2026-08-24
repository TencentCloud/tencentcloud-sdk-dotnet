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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InternetAccessible : AbstractModel
    {
        
        /// <summary>
        /// 网络计费类型。取值范围：BANDWIDTH_PREPAID（预付费按带宽结算）、TRAFFIC_POSTPAID_BY_HOUR（流量按小时后付费）、BANDWIDTH_POSTPAID_BY_HOUR（带宽按小时后付费）、BANDWIDTH_PACKAGE（带宽包用户）。默认取值：非带宽包用户默认与子机付费类型保持一致。
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// 公网出带宽上限，单位：Mbps。默认值：0Mbps。不同机型带宽上限范围不一致，具体限制详见购买网络带宽。
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 是否分配公网IP。取值范围：true（表示分配公网IP）/false（表示不分配公网IP）。当公网带宽大于0Mbps时，可自由选择开通与否，默认开通公网IP；当公网带宽为0，则不允许分配公网IP。该参数仅在 RunInstances 接口中作为入参使用。
        /// </summary>
        [JsonProperty("PublicIpAssigned")]
        public bool? PublicIpAssigned{ get; set; }

        /// <summary>
        /// 网络模式：移动:"CMCC"、电信:"CTCC"、联通:"CUCC"。
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "PublicIpAssigned", this.PublicIpAssigned);
            this.SetParamSimple(map, prefix + "InternetServiceProvider", this.InternetServiceProvider);
        }
    }
}

