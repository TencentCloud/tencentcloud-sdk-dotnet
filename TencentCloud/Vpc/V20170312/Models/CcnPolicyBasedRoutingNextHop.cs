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

    public class CcnPolicyBasedRoutingNextHop : AbstractModel
    {
        
        /// <summary>
        /// 策略路由下一跳ID
        /// </summary>
        [JsonProperty("PolicyBasedRoutingNextHopId")]
        public string PolicyBasedRoutingNextHopId{ get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 下一跳地域
        /// </summary>
        [JsonProperty("NextHopRegion")]
        public string NextHopRegion{ get; set; }

        /// <summary>
        /// 关联实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 状态(ENABLE/DISABLE)
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 关联实例类型[VPC,DIRECTCONNECT,VPNGW]
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 下一跳资源类型[HAVIP,GWLB_ENDPOINT]
        /// </summary>
        [JsonProperty("NextHopResourceType")]
        public string NextHopResourceType{ get; set; }

        /// <summary>
        /// 下一跳资源ID
        /// </summary>
        [JsonProperty("NextHopResourceId")]
        public string NextHopResourceId{ get; set; }

        /// <summary>
        /// 下一跳资源ip
        /// </summary>
        [JsonProperty("NextHopIp")]
        public string NextHopIp{ get; set; }

        /// <summary>
        /// 0
        /// </summary>
        [JsonProperty("PolicyBasedRoutingRulesCount")]
        public long? PolicyBasedRoutingRulesCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyBasedRoutingNextHopId", this.PolicyBasedRoutingNextHopId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NextHopRegion", this.NextHopRegion);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "NextHopResourceType", this.NextHopResourceType);
            this.SetParamSimple(map, prefix + "NextHopResourceId", this.NextHopResourceId);
            this.SetParamSimple(map, prefix + "NextHopIp", this.NextHopIp);
            this.SetParamSimple(map, prefix + "PolicyBasedRoutingRulesCount", this.PolicyBasedRoutingRulesCount);
        }
    }
}

