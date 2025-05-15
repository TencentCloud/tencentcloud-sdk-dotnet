/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class SecurityConfig : AbstractModel
    {
        
        /// <summary>
        /// 托管规则。如果入参为空或不填，默认使用历史配置。
        /// </summary>
        [JsonProperty("WafConfig")]
        public WafConfig WafConfig{ get; set; }

        /// <summary>
        /// 速率限制。如果入参为空或不填，默认使用历史配置。
        /// </summary>
        [JsonProperty("RateLimitConfig")]
        public RateLimitConfig RateLimitConfig{ get; set; }

        /// <summary>
        /// 自定义规则。如果入参为空或不填，默认使用历史配置。
        /// </summary>
        [JsonProperty("AclConfig")]
        public AclConfig AclConfig{ get; set; }

        /// <summary>
        /// Bot配置。如果入参为空或不填，默认使用历史配置。
        /// </summary>
        [JsonProperty("BotConfig")]
        public BotConfig BotConfig{ get; set; }

        /// <summary>
        /// 七层防护总开关。如果入参为空或不填，默认使用历史配置。
        /// </summary>
        [JsonProperty("SwitchConfig")]
        public SwitchConfig SwitchConfig{ get; set; }

        /// <summary>
        /// 基础访问管控。如果入参为空或不填，默认使用历史配置。
        /// </summary>
        [JsonProperty("IpTableConfig")]
        public IpTableConfig IpTableConfig{ get; set; }

        /// <summary>
        /// 例外规则配置。如果入参为空或不填，默认使用历史配置。
        /// </summary>
        [JsonProperty("ExceptConfig")]
        public ExceptConfig ExceptConfig{ get; set; }

        /// <summary>
        /// 自定义拦截页面配置。如果入参为空或不填，默认使用历史配置。
        /// </summary>
        [JsonProperty("DropPageConfig")]
        public DropPageConfig DropPageConfig{ get; set; }

        /// <summary>
        /// 模板配置。此处仅出参数使用。
        /// </summary>
        [JsonProperty("TemplateConfig")]
        public TemplateConfig TemplateConfig{ get; set; }

        /// <summary>
        /// 慢速攻击配置。如果入参为空或不填，默认使用历史配置。
        /// </summary>
        [JsonProperty("SlowPostConfig")]
        public SlowPostConfig SlowPostConfig{ get; set; }

        /// <summary>
        /// 检测长度限制配置。仅出参使用。
        /// </summary>
        [JsonProperty("DetectLengthLimitConfig")]
        public DetectLengthLimitConfig DetectLengthLimitConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "WafConfig.", this.WafConfig);
            this.SetParamObj(map, prefix + "RateLimitConfig.", this.RateLimitConfig);
            this.SetParamObj(map, prefix + "AclConfig.", this.AclConfig);
            this.SetParamObj(map, prefix + "BotConfig.", this.BotConfig);
            this.SetParamObj(map, prefix + "SwitchConfig.", this.SwitchConfig);
            this.SetParamObj(map, prefix + "IpTableConfig.", this.IpTableConfig);
            this.SetParamObj(map, prefix + "ExceptConfig.", this.ExceptConfig);
            this.SetParamObj(map, prefix + "DropPageConfig.", this.DropPageConfig);
            this.SetParamObj(map, prefix + "TemplateConfig.", this.TemplateConfig);
            this.SetParamObj(map, prefix + "SlowPostConfig.", this.SlowPostConfig);
            this.SetParamObj(map, prefix + "DetectLengthLimitConfig.", this.DetectLengthLimitConfig);
        }
    }
}

