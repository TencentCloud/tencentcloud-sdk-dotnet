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

namespace TencentCloud.Bsca.V20210811.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CVSSV3Info : AbstractModel
    {
        
        /// <summary>
        /// CVE评分。
        /// </summary>
        [JsonProperty("CVSS")]
        public float? CVSS{ get; set; }

        /// <summary>
        /// AttackVector 攻击途径。
        /// 取值范围：
        /// <li>NETWORK 远程</li>
        /// <li>ADJACENT_NETWORK 近邻</li>
        /// <li>LOCAL 本地</li>
        /// <li>PHYSICAL 物理</li>
        /// </summary>
        [JsonProperty("AttackVector")]
        public string AttackVector{ get; set; }

        /// <summary>
        /// AttackComplexity 攻击复杂度。
        /// 取值范围：
        /// <li>HIGH 高</li>
        /// <li>LOW 低</li>
        /// </summary>
        [JsonProperty("AttackComplexity")]
        public string AttackComplexity{ get; set; }

        /// <summary>
        /// PrivilegesRequired 触发特权。
        /// 取值范围：
        /// <li>HIGH 高</li>
        /// <li>LOW 低</li>
        /// <li>NONE 无</li>
        /// </summary>
        [JsonProperty("PrivilegesRequired")]
        public string PrivilegesRequired{ get; set; }

        /// <summary>
        /// UserInteraction 交互必要性。
        /// 取值范围：
        /// <li>NONE 无</li>
        /// <li>REQUIRED 需要</li>
        /// </summary>
        [JsonProperty("UserInteraction")]
        public string UserInteraction{ get; set; }

        /// <summary>
        /// Scope 绕过安全边界。
        /// 取值范围：
        /// <li>UNCHANGED 否</li>
        /// <li>CHANGED 能</li>
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// ConfidentialityImpact 机密性影响。
        /// 取值范围：
        /// <li>NONE 无</li>
        /// <li>LOW 低</li>
        /// <li>HIGH 高</li>
        /// </summary>
        [JsonProperty("ConImpact")]
        public string ConImpact{ get; set; }

        /// <summary>
        /// IntegrityImpact 完整性影响。
        /// 取值范围：
        /// <li>NONE 无</li>
        /// <li>LOW 低</li>
        /// <li>HIGH 高</li>
        /// </summary>
        [JsonProperty("IntegrityImpact")]
        public string IntegrityImpact{ get; set; }

        /// <summary>
        /// AvailabilityImpact 可用性影响。
        /// 取值范围：
        /// <li>NONE 无</li>
        /// <li>LOW 低</li>
        /// <li>HIGH 高</li>
        /// </summary>
        [JsonProperty("AvailabilityImpact")]
        public string AvailabilityImpact{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CVSS", this.CVSS);
            this.SetParamSimple(map, prefix + "AttackVector", this.AttackVector);
            this.SetParamSimple(map, prefix + "AttackComplexity", this.AttackComplexity);
            this.SetParamSimple(map, prefix + "PrivilegesRequired", this.PrivilegesRequired);
            this.SetParamSimple(map, prefix + "UserInteraction", this.UserInteraction);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "ConImpact", this.ConImpact);
            this.SetParamSimple(map, prefix + "IntegrityImpact", this.IntegrityImpact);
            this.SetParamSimple(map, prefix + "AvailabilityImpact", this.AvailabilityImpact);
        }
    }
}

