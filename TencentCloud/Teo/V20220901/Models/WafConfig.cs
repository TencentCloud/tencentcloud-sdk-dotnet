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

    public class WafConfig : AbstractModel
    {
        
        /// <summary>
        /// WafConfig开关，取值有：
        /// <li> on：开启；</li>
        /// <li> off：关闭。</li>开关仅与配置是否生效有关，即使为off（关闭），也可以正常修改配置的内容。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 上一次设置的防护级别，取值有：
        /// <li> loose：宽松；</li>
        /// <li> normal：正常；</li>
        /// <li> strict：严格；</li>
        /// <li> stricter：超严格；</li>
        /// <li> custom：自定义。</li>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 全局WAF模式，取值有：
        /// <li> block：阻断（全局阻断，但可对详细规则配置观察）；</li>
        /// <li> observe：观察（无论详细规则配置什么，都为观察）。</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 托管规则详细配置。如果为null，默认使用历史配置。
        /// </summary>
        [JsonProperty("WafRule")]
        public WafRule WafRule{ get; set; }

        /// <summary>
        /// AI规则引擎防护配置。如果为null，默认使用历史配置。
        /// </summary>
        [JsonProperty("AiRule")]
        public AiRule AiRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamObj(map, prefix + "WafRule.", this.WafRule);
            this.SetParamObj(map, prefix + "AiRule.", this.AiRule);
        }
    }
}

