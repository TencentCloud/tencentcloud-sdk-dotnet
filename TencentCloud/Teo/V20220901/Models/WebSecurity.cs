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

    public class WebSecurity : AbstractModel
    {
        
        /// <summary>
        /// 站点级策略的配置详情。
        /// </summary>
        [JsonProperty("ZoneDefaultPolicy")]
        public SecurityPolicy ZoneDefaultPolicy{ get; set; }

        /// <summary>
        /// 域名级策略的配置详情。
        /// </summary>
        [JsonProperty("HostPolicy")]
        public HostPolicy HostPolicy{ get; set; }

        /// <summary>
        /// 策略模板的配置详情。
        /// </summary>
        [JsonProperty("Templates")]
        public WebSecurityTemplates Templates{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ZoneDefaultPolicy.", this.ZoneDefaultPolicy);
            this.SetParamObj(map, prefix + "HostPolicy.", this.HostPolicy);
            this.SetParamObj(map, prefix + "Templates.", this.Templates);
        }
    }
}

