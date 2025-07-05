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

    public class IPv6InternetAccessible : AbstractModel
    {
        
        /// <summary>
        /// 网络计费模式。取值包括TRAFFIC_POSTPAID_BY_HOUR、BANDWIDTH_PACKAGE，默认取值为TRAFFIC_POSTPAID_BY_HOUR。查看当前账户类型可参考[账户类型说明](https://cloud.tencent.com/document/product/1199/49090#judge)。
        /// <br><li> IPv6对标准账户类型支持TRAFFIC_POSTPAID_BY_HOUR。
        /// <br><li> IPv6对传统账户类型支持BANDWIDTH_PACKAGE。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// 公网出带宽上限，单位：Mbps。<br>默认值：0，此时不为IPv6分配公网带宽。不同机型、可用区、计费模式的带宽上限范围不一致，具体限制详见[公网带宽上限](https://cloud.tencent.com/document/product/213/12523)。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 带宽包ID。可通过[DescribeBandwidthPackages](https://cloud.tencent.com/document/api/215/19209)接口返回值中的`BandwidthPackageId`获取。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
        }
    }
}

