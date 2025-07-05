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

namespace TencentCloud.Hai.V20230812.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkStatus : AbstractModel
    {
        
        /// <summary>
        /// HAI 的实例 ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 公网 IP 地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AddressIp")]
        public string AddressIp{ get; set; }

        /// <summary>
        /// 出带宽上限，单位Mbps
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// 流量包总量，单位GB
        /// </summary>
        [JsonProperty("TotalTrafficAmount")]
        public float? TotalTrafficAmount{ get; set; }

        /// <summary>
        /// 流量包剩余量，单位GB
        /// </summary>
        [JsonProperty("RemainingTrafficAmount")]
        public float? RemainingTrafficAmount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AddressIp", this.AddressIp);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "TotalTrafficAmount", this.TotalTrafficAmount);
            this.SetParamSimple(map, prefix + "RemainingTrafficAmount", this.RemainingTrafficAmount);
        }
    }
}

