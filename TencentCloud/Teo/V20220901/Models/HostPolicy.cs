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

    public class HostPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>站点级策略，针对站点下所有域名生效的策略，详情见 站点级策略。</p>
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// <p>当前域名使用的策略类型。取值有：<li>ZoneDefault：使用站点级策略，即 ZoneDefaultPolicy 中定义的策略配置。</li><li>Custom：使用域名级策略。使用该选项时，必须同时配置 Policy 字段，指定详细策略配置。</li><li>Template：使用策略模板。使用该选项时，必须同时配置 TemplateId 字段，指定当前域名使用的策略模板。</li></p>
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// <p>可选。当 PolicyType 为 Custom 时，该字段为当前域名的详细策略配置，对当前域名生效。</p>
        /// </summary>
        [JsonProperty("Policy")]
        public SecurityPolicy Policy{ get; set; }

        /// <summary>
        /// <p>可选。当 PolicyType 为 Template 时，该字段用于指定当前域名所使用的策略模板的 Id。</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamObj(map, prefix + "Policy.", this.Policy);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
        }
    }
}

