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

    public class CcnPolicyBasedRoutingRule : AbstractModel
    {
        
        /// <summary>
        /// <p>策略路由下一跳ID</p>
        /// </summary>
        [JsonProperty("PolicyBasedRoutingNextHopId")]
        public string PolicyBasedRoutingNextHopId{ get; set; }

        /// <summary>
        /// <p>实例类型[VPC,DIRECTCONNECT,VPNGW]</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>源地址CIDR</p>
        /// </summary>
        [JsonProperty("SourceCidrBlock")]
        public string SourceCidrBlock{ get; set; }

        /// <summary>
        /// <p>目的地址CIDR</p>
        /// </summary>
        [JsonProperty("DestinationCidrBlock")]
        public string DestinationCidrBlock{ get; set; }

        /// <summary>
        /// <p>优先级</p>
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>策略路由匹配策略ID</p>
        /// </summary>
        [JsonProperty("PolicyBasedRoutingRuleId")]
        public string PolicyBasedRoutingRuleId{ get; set; }

        /// <summary>
        /// <p>目的端实例ID</p><p>枚举值：</p><ul><li>VPC： 私有网络</li></ul>
        /// </summary>
        [JsonProperty("DestinationInstanceType")]
        public string DestinationInstanceType{ get; set; }

        /// <summary>
        /// <p>目的端实例ID</p>
        /// </summary>
        [JsonProperty("DestinationInstanceId")]
        public string DestinationInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyBasedRoutingNextHopId", this.PolicyBasedRoutingNextHopId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SourceCidrBlock", this.SourceCidrBlock);
            this.SetParamSimple(map, prefix + "DestinationCidrBlock", this.DestinationCidrBlock);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PolicyBasedRoutingRuleId", this.PolicyBasedRoutingRuleId);
            this.SetParamSimple(map, prefix + "DestinationInstanceType", this.DestinationInstanceType);
            this.SetParamSimple(map, prefix + "DestinationInstanceId", this.DestinationInstanceId);
        }
    }
}

