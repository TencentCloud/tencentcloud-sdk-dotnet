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
        /// <p>CCN实例ID。形如：ccn-f49l6u0z。</p>
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// <p>qos id。</p>
        /// </summary>
        [JsonProperty("QosId")]
        public ulong? QosId{ get; set; }

        /// <summary>
        /// <p>描述。</p>
        /// </summary>
        [JsonProperty("QosPolicyDescription")]
        public string QosPolicyDescription{ get; set; }

        /// <summary>
        /// <p>名称。</p>
        /// </summary>
        [JsonProperty("QosPolicyName")]
        public string QosPolicyName{ get; set; }

        /// <summary>
        /// <p>带宽。</p>
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// <p>流量调度策略ID。</p>
        /// </summary>
        [JsonProperty("QosPolicyId")]
        public string QosPolicyId{ get; set; }

        /// <summary>
        /// <p>服务等级信息</p>
        /// </summary>
        [JsonProperty("QosLevel")]
        public string QosLevel{ get; set; }

        /// <summary>
        /// <p>服务等级信息</p>
        /// </summary>
        [JsonProperty("ServiceLevel")]
        public string ServiceLevel{ get; set; }

        /// <summary>
        /// <p>带宽ID</p><p>参数格式：fcr-xxx</p>
        /// </summary>
        [JsonProperty("RegionFlowControlId")]
        public string RegionFlowControlId{ get; set; }

        /// <summary>
        /// <p>源地域</p><p>参数格式：ap-xxx</p>
        /// </summary>
        [JsonProperty("LocalRegion")]
        public string LocalRegion{ get; set; }

        /// <summary>
        /// <p>目的地域</p><p>参数格式：ap-xxx</p>
        /// </summary>
        [JsonProperty("RemoteRegion")]
        public string RemoteRegion{ get; set; }

        /// <summary>
        /// <p>流量匹配策略ID</p>
        /// </summary>
        [JsonProperty("TrafficMatchPolicyId")]
        public string TrafficMatchPolicyId{ get; set; }


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
            this.SetParamSimple(map, prefix + "QosLevel", this.QosLevel);
            this.SetParamSimple(map, prefix + "ServiceLevel", this.ServiceLevel);
            this.SetParamSimple(map, prefix + "RegionFlowControlId", this.RegionFlowControlId);
            this.SetParamSimple(map, prefix + "LocalRegion", this.LocalRegion);
            this.SetParamSimple(map, prefix + "RemoteRegion", this.RemoteRegion);
            this.SetParamSimple(map, prefix + "TrafficMatchPolicyId", this.TrafficMatchPolicyId);
        }
    }
}

