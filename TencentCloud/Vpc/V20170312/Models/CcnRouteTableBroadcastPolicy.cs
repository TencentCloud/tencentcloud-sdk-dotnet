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

    public class CcnRouteTableBroadcastPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>路由条件</p>
        /// </summary>
        [JsonProperty("RouteConditions")]
        public CcnRouteBroadcastPolicyRouteCondition[] RouteConditions{ get; set; }

        /// <summary>
        /// <p>传播条件</p>
        /// </summary>
        [JsonProperty("BroadcastConditions")]
        public CcnRouteBroadcastPolicyRouteCondition[] BroadcastConditions{ get; set; }

        /// <summary>
        /// <p>路由行为，<code>accept</code> 允许，<code>drop</code> 拒绝</p>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>策略描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>as-path操作</p>
        /// </summary>
        [JsonProperty("OperateAsPath")]
        public string OperateAsPath{ get; set; }

        /// <summary>
        /// <p>as-path操作模式</p>
        /// </summary>
        [JsonProperty("AsPathOperateMode")]
        public string AsPathOperateMode{ get; set; }

        /// <summary>
        /// <p>community操作</p>
        /// </summary>
        [JsonProperty("OperateCommunitySet")]
        public string[] OperateCommunitySet{ get; set; }

        /// <summary>
        /// <p>community操作模式</p>
        /// </summary>
        [JsonProperty("CommunityOperateMode")]
        public string CommunityOperateMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "RouteConditions.", this.RouteConditions);
            this.SetParamArrayObj(map, prefix + "BroadcastConditions.", this.BroadcastConditions);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OperateAsPath", this.OperateAsPath);
            this.SetParamSimple(map, prefix + "AsPathOperateMode", this.AsPathOperateMode);
            this.SetParamArraySimple(map, prefix + "OperateCommunitySet.", this.OperateCommunitySet);
            this.SetParamSimple(map, prefix + "CommunityOperateMode", this.CommunityOperateMode);
        }
    }
}

