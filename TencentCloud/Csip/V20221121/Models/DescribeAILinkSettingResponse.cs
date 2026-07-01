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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAILinkSettingResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>0 关闭AI-Link智链引擎，1 开启AI-Link智链引擎</p>
        /// </summary>
        [JsonProperty("AILinkEnable")]
        public ulong? AILinkEnable{ get; set; }

        /// <summary>
        /// <p>深度模式 0-关闭 1-开启</p>
        /// </summary>
        [JsonProperty("RuleScopeDeep")]
        public ulong? RuleScopeDeep{ get; set; }

        /// <summary>
        /// <p>均衡模式 0-关闭 1-开启</p>
        /// </summary>
        [JsonProperty("RuleScopeBalanced")]
        public ulong? RuleScopeBalanced{ get; set; }

        /// <summary>
        /// <p>精准模式 0-关闭 1-开启</p>
        /// </summary>
        [JsonProperty("RuleScopePrecise")]
        public ulong? RuleScopePrecise{ get; set; }

        /// <summary>
        /// <p>1 全部专业/旗舰版主机，0 Quuids列表主机</p>
        /// </summary>
        [JsonProperty("Scope")]
        public ulong? Scope{ get; set; }

        /// <summary>
        /// <p>自选主机Quuid列表</p>
        /// </summary>
        [JsonProperty("Quuids")]
        public string[] Quuids{ get; set; }

        /// <summary>
        /// <p>排除主机Quuid列表</p>
        /// </summary>
        [JsonProperty("ExcludeQuuids")]
        public string[] ExcludeQuuids{ get; set; }

        /// <summary>
        /// <p>新增资产自动包含 0 不包含 1包含</p>
        /// </summary>
        [JsonProperty("AutoInclude")]
        public ulong? AutoInclude{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AILinkEnable", this.AILinkEnable);
            this.SetParamSimple(map, prefix + "RuleScopeDeep", this.RuleScopeDeep);
            this.SetParamSimple(map, prefix + "RuleScopeBalanced", this.RuleScopeBalanced);
            this.SetParamSimple(map, prefix + "RuleScopePrecise", this.RuleScopePrecise);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamArraySimple(map, prefix + "Quuids.", this.Quuids);
            this.SetParamArraySimple(map, prefix + "ExcludeQuuids.", this.ExcludeQuuids);
            this.SetParamSimple(map, prefix + "AutoInclude", this.AutoInclude);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

