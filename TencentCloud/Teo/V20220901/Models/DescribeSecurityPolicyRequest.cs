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

    public class DescribeSecurityPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 安全策略类型，可使用以下参数值进行查询： <li>ZoneDefaultPolicy：用于指定查询站点级策略；</li><li>Template：用于指定查询策略模板，需要同时指定 TemplateId 参数；</li><li>Host：用于指定查询域名级策略（注意：当使用域名来指定域名服务策略时，仅支持已经应用了域名级策略的域名服务或者策略模板）。</li>	
        /// </summary>
        [JsonProperty("Entity")]
        public string Entity{ get; set; }

        /// <summary>
        /// 指定策略模板 ID。当 Entity 参数值为 Template 时，使用本参数指定策略模板的 ID 查询模板配置。
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 指定域名。当 Entity 参数值为 Host 时，使用本参数指定的域名级策略查询域名配置，例如：使用 www.example.com ，配置该域名的域名级策略。
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Entity", this.Entity);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Host", this.Host);
        }
    }
}

