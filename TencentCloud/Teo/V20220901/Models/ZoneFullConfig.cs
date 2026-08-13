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

    public class ZoneFullConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>语法版本，当前默认为 1.0，输入其他值将会报错。</p>
        /// </summary>
        [JsonProperty("FormatVersion")]
        public string FormatVersion{ get; set; }

        /// <summary>
        /// <p>站点级配置，包含「站点加速」中所有配置项，且所有项均为必选，否则配置无效。</p>
        /// </summary>
        [JsonProperty("ZoneConfig")]
        public ZoneConfig ZoneConfig{ get; set; }

        /// <summary>
        /// <p>规则级配置，包含「规则引擎」中所有规则，且数组可为空，表示不启用任何规则。</p>
        /// </summary>
        [JsonProperty("Rules")]
        public ConfigGroupRuleEngineItem[] Rules{ get; set; }

        /// <summary>
        /// <p>Web 安全防护配置，对应控制台中「安全防护 - Web 防护」里支持的功能。</p>
        /// </summary>
        [JsonProperty("WebSecurity")]
        public WebSecurity WebSecurity{ get; set; }

        /// <summary>
        /// <p>边缘函数触发规则配置，包含触发「边缘函数」中所有规则，且数组可为空，表示不启用任何规则。</p>
        /// </summary>
        [JsonProperty("FunctionTriggers")]
        public ConfigGroupFunctionTrigger[] FunctionTriggers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FormatVersion", this.FormatVersion);
            this.SetParamObj(map, prefix + "ZoneConfig.", this.ZoneConfig);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamObj(map, prefix + "WebSecurity.", this.WebSecurity);
            this.SetParamArrayObj(map, prefix + "FunctionTriggers.", this.FunctionTriggers);
        }
    }
}

