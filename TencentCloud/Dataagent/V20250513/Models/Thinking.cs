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

namespace TencentCloud.Dataagent.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Thinking : AbstractModel
    {
        
        /// <summary>
        /// <p>模式</p><p>枚举值：</p><ul><li>toggle： 可开关</li><li>always_on： 固定开启</li><li>always_off： 固定关闭</li><li>unconfigured： 未配置</li></ul>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>默认是否开启思考</p>
        /// </summary>
        [JsonProperty("DefaultEnabled")]
        public bool? DefaultEnabled{ get; set; }

        /// <summary>
        /// <p>思考强度可选项，如 [&quot;high&quot;,&quot;max&quot;]</p>
        /// </summary>
        [JsonProperty("EffortOptions")]
        public string[] EffortOptions{ get; set; }

        /// <summary>
        /// <p>默认思考强度</p>
        /// </summary>
        [JsonProperty("DefaultEffort")]
        public string DefaultEffort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "DefaultEnabled", this.DefaultEnabled);
            this.SetParamArraySimple(map, prefix + "EffortOptions.", this.EffortOptions);
            this.SetParamSimple(map, prefix + "DefaultEffort", this.DefaultEffort);
        }
    }
}

