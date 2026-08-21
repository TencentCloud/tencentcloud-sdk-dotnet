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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProtectionConfigItem : AbstractModel
    {
        
        /// <summary>
        /// 配置项ID
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 配置项名称
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// 配置项描述
        /// </summary>
        [JsonProperty("ConfigDescription")]
        public string ConfigDescription{ get; set; }

        /// <summary>
        /// 配置分组
        /// 枚举值：
        /// auto_risk_discovery：自动风险发现
        /// auto_defense：自动防御
        /// client_hardening：客户端强化
        /// </summary>
        [JsonProperty("ConfigGroup")]
        public string ConfigGroup{ get; set; }

        /// <summary>
        /// 是否已开启
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamSimple(map, prefix + "ConfigDescription", this.ConfigDescription);
            this.SetParamSimple(map, prefix + "ConfigGroup", this.ConfigGroup);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

