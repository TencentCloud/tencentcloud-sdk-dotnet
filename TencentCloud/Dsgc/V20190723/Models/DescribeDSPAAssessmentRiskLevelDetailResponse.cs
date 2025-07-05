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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDSPAAssessmentRiskLevelDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 风险级别名称
        /// </summary>
        [JsonProperty("RiskLevelName")]
        public string RiskLevelName{ get; set; }

        /// <summary>
        /// 风险级别描述
        /// </summary>
        [JsonProperty("RiskLevelDescription")]
        public string RiskLevelDescription{ get; set; }

        /// <summary>
        /// 分类分级id
        /// </summary>
        [JsonProperty("IdentifyComplianceId")]
        public long? IdentifyComplianceId{ get; set; }

        /// <summary>
        /// 分类分级模板名称
        /// </summary>
        [JsonProperty("IdentifyComplianceName")]
        public string IdentifyComplianceName{ get; set; }

        /// <summary>
        /// 风险数据
        /// </summary>
        [JsonProperty("RiskLevelMatrix")]
        public RiskLevelMatrix[] RiskLevelMatrix{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskLevelName", this.RiskLevelName);
            this.SetParamSimple(map, prefix + "RiskLevelDescription", this.RiskLevelDescription);
            this.SetParamSimple(map, prefix + "IdentifyComplianceId", this.IdentifyComplianceId);
            this.SetParamSimple(map, prefix + "IdentifyComplianceName", this.IdentifyComplianceName);
            this.SetParamArrayObj(map, prefix + "RiskLevelMatrix.", this.RiskLevelMatrix);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

