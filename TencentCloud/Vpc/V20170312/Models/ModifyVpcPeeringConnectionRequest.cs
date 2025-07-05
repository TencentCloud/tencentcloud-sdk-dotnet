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

    public class ModifyVpcPeeringConnectionRequest : AbstractModel
    {
        
        /// <summary>
        /// 对等连接ID。
        /// </summary>
        [JsonProperty("PeeringConnectionId")]
        public string PeeringConnectionId{ get; set; }

        /// <summary>
        /// 对等连接名称。
        /// </summary>
        [JsonProperty("PeeringConnectionName")]
        public string PeeringConnectionName{ get; set; }

        /// <summary>
        /// 带宽上限，单位Mbps。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 计费模式，日峰值POSTPAID_BY_DAY_MAX，月95 POSTPAID_BY_MONTH_95。
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PeeringConnectionId", this.PeeringConnectionId);
            this.SetParamSimple(map, prefix + "PeeringConnectionName", this.PeeringConnectionName);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
        }
    }
}

