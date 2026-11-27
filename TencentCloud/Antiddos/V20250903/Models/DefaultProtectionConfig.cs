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

namespace TencentCloud.Antiddos.V20250903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DefaultProtectionConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>DDoS 防护等级配置，决定清洗策略的灵敏度。</p><p>枚举值：</p><ul><li>high： 高灵敏度。清洗策略相对严格，建议在正常模式出现攻击透传时使用。</li><li>medium： 适中灵敏度（默认）。清洗策略适配绝大多数业务，可有效防护常见攻击。</li><li>low： 宽松灵敏度。清洗策略相对宽松，仅对具有明确攻击特征的攻击包进行防护。</li></ul><p>详见 <a href="https://cloud.tencent.com/document/product/297/139103">各个防护等级防护策略</a> 说明。</p>
        /// </summary>
        [JsonProperty("SensitivityLevel")]
        public string SensitivityLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SensitivityLevel", this.SensitivityLevel);
        }
    }
}

