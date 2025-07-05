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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SaDivulgeScanRuleMutateRequest : AbstractModel
    {
        
        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// DivulgeSoure
        /// </summary>
        [JsonProperty("DivulgeSoure")]
        public string DivulgeSoure{ get; set; }

        /// <summary>
        /// DivulgeSoureUrl
        /// </summary>
        [JsonProperty("DivulgeSoureUrl")]
        public string DivulgeSoureUrl{ get; set; }

        /// <summary>
        /// RuleName
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// RuleWord
        /// </summary>
        [JsonProperty("RuleWord")]
        public string RuleWord{ get; set; }

        /// <summary>
        /// ScanStatus
        /// </summary>
        [JsonProperty("ScanStatus")]
        public string ScanStatus{ get; set; }

        /// <summary>
        /// DivulgeType
        /// </summary>
        [JsonProperty("DivulgeType")]
        public string DivulgeType{ get; set; }

        /// <summary>
        /// RepairAdvice
        /// </summary>
        [JsonProperty("RepairAdvice")]
        public string RepairAdvice{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "DivulgeSoure", this.DivulgeSoure);
            this.SetParamSimple(map, prefix + "DivulgeSoureUrl", this.DivulgeSoureUrl);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleWord", this.RuleWord);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "DivulgeType", this.DivulgeType);
            this.SetParamSimple(map, prefix + "RepairAdvice", this.RepairAdvice);
        }
    }
}

