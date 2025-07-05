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

    public class SetCcnRegionBandwidthLimitsRequest : AbstractModel
    {
        
        /// <summary>
        /// CCN实例ID，形如：ccn-f49l6u0z。
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// 云联网（CCN）各地域出带宽上限。
        /// </summary>
        [JsonProperty("CcnRegionBandwidthLimits")]
        public CcnRegionBandwidthLimit[] CcnRegionBandwidthLimits{ get; set; }

        /// <summary>
        /// 是否恢复云联网地域出口/地域间带宽限速为默认值（1Gbps）。false表示不恢复；true表示恢复。恢复默认值后，限速实例将不在控制台展示。该参数默认为 false，不恢复。
        /// </summary>
        [JsonProperty("SetDefaultLimitFlag")]
        public bool? SetDefaultLimitFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamArrayObj(map, prefix + "CcnRegionBandwidthLimits.", this.CcnRegionBandwidthLimits);
            this.SetParamSimple(map, prefix + "SetDefaultLimitFlag", this.SetDefaultLimitFlag);
        }
    }
}

