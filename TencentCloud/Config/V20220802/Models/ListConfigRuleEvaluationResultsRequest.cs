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

    public class ListConfigRuleEvaluationResultsRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("ConfigRuleId")]
        public string ConfigRuleId{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("ResourceType")]
        public string[] ResourceType{ get; set; }

        /// <summary>
        /// 评估结果 COMPLIANT：合规   NON_COMPLIANT：不合规
        /// </summary>
        [JsonProperty("ComplianceType")]
        public string[] ComplianceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigRuleId", this.ConfigRuleId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArraySimple(map, prefix + "ResourceType.", this.ResourceType);
            this.SetParamArraySimple(map, prefix + "ComplianceType.", this.ComplianceType);
        }
    }
}

