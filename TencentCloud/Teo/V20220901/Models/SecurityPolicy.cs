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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityPolicy : AbstractModel
    {
        
        /// <summary>
        /// 自定义规则配置。
        /// </summary>
        [JsonProperty("CustomRules")]
        public CustomRules CustomRules{ get; set; }

        /// <summary>
        /// 托管规则配置。
        /// </summary>
        [JsonProperty("ManagedRules")]
        public ManagedRules ManagedRules{ get; set; }

        /// <summary>
        /// HTTP DDOS 防护配置。
        /// </summary>
        [JsonProperty("HttpDDoSProtection")]
        public HttpDDoSProtection HttpDDoSProtection{ get; set; }

        /// <summary>
        /// 速率限制规则配置。
        /// </summary>
        [JsonProperty("RateLimitingRules")]
        public RateLimitingRules RateLimitingRules{ get; set; }

        /// <summary>
        /// 例外规则配置。
        /// </summary>
        [JsonProperty("ExceptionRules")]
        public ExceptionRules ExceptionRules{ get; set; }

        /// <summary>
        /// Bot 管理配置。
        /// </summary>
        [JsonProperty("BotManagement")]
        public BotManagement BotManagement{ get; set; }

        /// <summary>
        /// 基础 Bot 管理配置。
        /// </summary>
        [JsonProperty("BotManagementLite")]
        public BotManagementLite BotManagementLite{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CustomRules.", this.CustomRules);
            this.SetParamObj(map, prefix + "ManagedRules.", this.ManagedRules);
            this.SetParamObj(map, prefix + "HttpDDoSProtection.", this.HttpDDoSProtection);
            this.SetParamObj(map, prefix + "RateLimitingRules.", this.RateLimitingRules);
            this.SetParamObj(map, prefix + "ExceptionRules.", this.ExceptionRules);
            this.SetParamObj(map, prefix + "BotManagement.", this.BotManagement);
            this.SetParamObj(map, prefix + "BotManagementLite.", this.BotManagementLite);
        }
    }
}

