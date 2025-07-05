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

    public class BandwidthRange : AbstractModel
    {
        
        /// <summary>
        /// 资源ID。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 带宽下限，单位：Mbps。计费类型以及对应的带宽下限：
        /// - TOP5_POSTPAID_BY_MONTH: 默认无下限
        /// - BANDWIDTH_POSTPAID_BY_DAY: 50
        /// - FIXED_PREPAID_BY_MONTH: 100
        /// - ENHANCED95_POSTPAID_BY_MONTH: 300
        /// - PEAK_BANDWIDTH_POSTPAID_BY_DAY: 50
        /// - PRIMARY_TRAFFIC_POSTPAID_BY_HOUR: 50
        /// </summary>
        [JsonProperty("BandwidthLowerLimit")]
        public ulong? BandwidthLowerLimit{ get; set; }

        /// <summary>
        /// 带宽上限，单位：Mbps。计费类型以及对应的带宽上限：
        /// - TOP5_POSTPAID_BY_MONTH: 默认无上限
        /// - BANDWIDTH_POSTPAID_BY_DAY: 300
        /// - FIXED_PREPAID_BY_MONTH: 5000
        /// - ENHANCED95_POSTPAID_BY_MONTH: 5000
        /// - PEAK_BANDWIDTH_POSTPAID_BY_DAY: 300
        /// - PRIMARY_TRAFFIC_POSTPAID_BY_HOUR: 2000
        /// </summary>
        [JsonProperty("BandwidthUpperLimit")]
        public ulong? BandwidthUpperLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "BandwidthLowerLimit", this.BandwidthLowerLimit);
            this.SetParamSimple(map, prefix + "BandwidthUpperLimit", this.BandwidthUpperLimit);
        }
    }
}

