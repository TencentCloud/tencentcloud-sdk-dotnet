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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCrossBorderSettlementRequest : AbstractModel
    {
        
        /// <summary>
        /// 全球加速实例ID。
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// 加速地域。
        /// </summary>
        [JsonProperty("AccelerateRegion")]
        public string AccelerateRegion{ get; set; }

        /// <summary>
        /// 终端节点组地域。
        /// </summary>
        [JsonProperty("EndpointGroupRegion")]
        public string EndpointGroupRegion{ get; set; }

        /// <summary>
        /// 账单年月时间。
        /// </summary>
        [JsonProperty("SettlementMonth")]
        public ulong? SettlementMonth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "AccelerateRegion", this.AccelerateRegion);
            this.SetParamSimple(map, prefix + "EndpointGroupRegion", this.EndpointGroupRegion);
            this.SetParamSimple(map, prefix + "SettlementMonth", this.SettlementMonth);
        }
    }
}

