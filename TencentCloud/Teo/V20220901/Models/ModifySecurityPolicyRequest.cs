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

    public class ModifySecurityPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点Id。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 安全配置。
        /// </summary>
        [JsonProperty("SecurityConfig")]
        public SecurityConfig SecurityConfig{ get; set; }

        /// <summary>
        /// 子域名/应用名。
        /// 
        /// 注意：当同时指定本参数和 TemplateId 参数时，本参数不生效。请勿同时指定本参数和 TemplateId 参数。
        /// </summary>
        [JsonProperty("Entity")]
        public string Entity{ get; set; }

        /// <summary>
        /// 指定模板策略 ID，或指定站点全局策略。
        /// - 如需配置策略模板，请指定策略模板 ID。
        /// - 如需配置站点全局策略，请使用 @ZoneLevel@Domain 参数值
        /// 
        /// 注意：当使用本参数时，Entity 参数不生效。请勿同时使用本参数和 Entity 参数。
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamObj(map, prefix + "SecurityConfig.", this.SecurityConfig);
            this.SetParamSimple(map, prefix + "Entity", this.Entity);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
        }
    }
}

