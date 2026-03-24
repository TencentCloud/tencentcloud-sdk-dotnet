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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddCompliancePackRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>合规包规则</p>
        /// </summary>
        [JsonProperty("ConfigRules")]
        public CompliancePackRule[] ConfigRules{ get; set; }

        /// <summary>
        /// <p>风险等级<br>1：高风险。<br>2：中风险。<br>3：低风险。</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public ulong? RiskLevel{ get; set; }

        /// <summary>
        /// <p>合规包名称</p>
        /// </summary>
        [JsonProperty("CompliancePackName")]
        public string CompliancePackName{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ConfigRules.", this.ConfigRules);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "CompliancePackName", this.CompliancePackName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

