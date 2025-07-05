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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrafficPackage : AbstractModel
    {
        
        /// <summary>
        /// 流量包ID。
        /// </summary>
        [JsonProperty("TrafficPackageId")]
        public string TrafficPackageId{ get; set; }

        /// <summary>
        /// 流量包生效周期内已使用流量，单位字节。
        /// </summary>
        [JsonProperty("TrafficUsed")]
        public long? TrafficUsed{ get; set; }

        /// <summary>
        /// 流量包生效周期内的总流量，单位字节。
        /// </summary>
        [JsonProperty("TrafficPackageTotal")]
        public long? TrafficPackageTotal{ get; set; }

        /// <summary>
        /// 流量包生效周期内的剩余流量，单位字节。
        /// </summary>
        [JsonProperty("TrafficPackageRemaining")]
        public long? TrafficPackageRemaining{ get; set; }

        /// <summary>
        /// 流量包生效周期内超出流量包额度的流量，单位字节。
        /// </summary>
        [JsonProperty("TrafficOverflow")]
        public long? TrafficOverflow{ get; set; }

        /// <summary>
        /// 流量包生效周期开始时间。按照 ISO8601 标准表示，并且使用 UTC 时间。 
        /// 格式为： YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 流量包生效周期结束时间。按照 ISO8601 标准表示，并且使用 UTC 时间。 
        /// 格式为： YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 流量包到期时间。按照 ISO8601 标准表示，并且使用 UTC 时间。 
        /// 格式为： YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// 流量包状态：
        /// <li>NETWORK_NORMAL：正常</li>
        /// <li>OVERDUE_NETWORK_DISABLED：欠费断网</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrafficPackageId", this.TrafficPackageId);
            this.SetParamSimple(map, prefix + "TrafficUsed", this.TrafficUsed);
            this.SetParamSimple(map, prefix + "TrafficPackageTotal", this.TrafficPackageTotal);
            this.SetParamSimple(map, prefix + "TrafficPackageRemaining", this.TrafficPackageRemaining);
            this.SetParamSimple(map, prefix + "TrafficOverflow", this.TrafficOverflow);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

