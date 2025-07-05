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

    public class TrafficQosPolicySet : AbstractModel
    {
        
        /// <summary>
        /// CCN实例ID。形如：ccn-f49l6u0z。
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// qos id。
        /// </summary>
        [JsonProperty("QosId")]
        public ulong? QosId{ get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [JsonProperty("QosPolicyDescription")]
        public string QosPolicyDescription{ get; set; }

        /// <summary>
        /// 名称。
        /// </summary>
        [JsonProperty("QosPolicyName")]
        public string QosPolicyName{ get; set; }

        /// <summary>
        /// 带宽。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// 流量调度策略ID。
        /// </summary>
        [JsonProperty("QosPolicyId")]
        public string QosPolicyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "QosId", this.QosId);
            this.SetParamSimple(map, prefix + "QosPolicyDescription", this.QosPolicyDescription);
            this.SetParamSimple(map, prefix + "QosPolicyName", this.QosPolicyName);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "QosPolicyId", this.QosPolicyId);
        }
    }
}

