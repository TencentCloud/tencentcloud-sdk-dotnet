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

namespace TencentCloud.Apis.V20240801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ToolConfigVO : AbstractModel
    {
        
        /// <summary>
        /// 工具名称
        /// </summary>
        [JsonProperty("ToolName")]
        public string ToolName{ get; set; }

        /// <summary>
        /// 是否开启限流配置
        /// </summary>
        [JsonProperty("InvokeLimitConfigStatus")]
        public bool? InvokeLimitConfigStatus{ get; set; }

        /// <summary>
        /// 限流配置
        /// </summary>
        [JsonProperty("InvokeLimitConfig")]
        public InvokeLimitConfigDTO InvokeLimitConfig{ get; set; }

        /// <summary>
        /// 绑定安全规则（响应）
        /// </summary>
        [JsonProperty("McpSecurityRules")]
        public BindMcpSecurityRuleVO[] McpSecurityRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ToolName", this.ToolName);
            this.SetParamSimple(map, prefix + "InvokeLimitConfigStatus", this.InvokeLimitConfigStatus);
            this.SetParamObj(map, prefix + "InvokeLimitConfig.", this.InvokeLimitConfig);
            this.SetParamArrayObj(map, prefix + "McpSecurityRules.", this.McpSecurityRules);
        }
    }
}

