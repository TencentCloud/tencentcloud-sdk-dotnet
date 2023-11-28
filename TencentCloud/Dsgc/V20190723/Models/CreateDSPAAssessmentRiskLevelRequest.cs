/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDSPAAssessmentRiskLevelRequest : AbstractModel
    {
        
        /// <summary>
        /// dspa实例id
        /// </summary>
        [JsonProperty("DspaId")]
        public string DspaId{ get; set; }

        /// <summary>
        /// 风险等级名称
        /// </summary>
        [JsonProperty("RiskLevelName")]
        public string RiskLevelName{ get; set; }

        /// <summary>
        /// 识别模板
        /// </summary>
        [JsonProperty("IdentifyComplianceId")]
        public long? IdentifyComplianceId{ get; set; }

        /// <summary>
        /// 风险等级矩阵
        /// </summary>
        [JsonProperty("RiskLevelRule")]
        public RiskLevelMatrix[] RiskLevelRule{ get; set; }

        /// <summary>
        /// 风险等级的描述
        /// </summary>
        [JsonProperty("RiskLevelDescription")]
        public string RiskLevelDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DspaId", this.DspaId);
            this.SetParamSimple(map, prefix + "RiskLevelName", this.RiskLevelName);
            this.SetParamSimple(map, prefix + "IdentifyComplianceId", this.IdentifyComplianceId);
            this.SetParamArrayObj(map, prefix + "RiskLevelRule.", this.RiskLevelRule);
            this.SetParamSimple(map, prefix + "RiskLevelDescription", this.RiskLevelDescription);
        }
    }
}

