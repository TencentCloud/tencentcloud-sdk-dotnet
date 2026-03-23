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

    public class DescribeMcpServersRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// 状态数组：normal正常状态，disabled下线状态
        /// </summary>
        [JsonProperty("Statuses")]
        public string[] Statuses{ get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// 服务ID数组
        /// </summary>
        [JsonProperty("IDs")]
        public string[] IDs{ get; set; }

        /// <summary>
        /// 模式：proxy代理模式； wrap封装模式；
        /// </summary>
        [JsonProperty("Modes")]
        public string[] Modes{ get; set; }

        /// <summary>
        /// 绑定的安全规则ID
        /// </summary>
        [JsonProperty("McpSecurityRuleID")]
        public string McpSecurityRuleID{ get; set; }

        /// <summary>
        /// 绑定安全规则的处置动作（填写时McpSecurityRuleID得必填）
        /// </summary>
        [JsonProperty("McpSecurityRuleAct")]
        public string McpSecurityRuleAct{ get; set; }

        /// <summary>
        /// 已绑定插件id
        /// </summary>
        [JsonProperty("PluginID")]
        public string PluginID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamArraySimple(map, prefix + "Statuses.", this.Statuses);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamArraySimple(map, prefix + "IDs.", this.IDs);
            this.SetParamArraySimple(map, prefix + "Modes.", this.Modes);
            this.SetParamSimple(map, prefix + "McpSecurityRuleID", this.McpSecurityRuleID);
            this.SetParamSimple(map, prefix + "McpSecurityRuleAct", this.McpSecurityRuleAct);
            this.SetParamSimple(map, prefix + "PluginID", this.PluginID);
        }
    }
}

