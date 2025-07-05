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

    public class DescribeRiskRuleDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 风险规则ID
        /// </summary>
        [JsonProperty("RiskRuleId")]
        public string RiskRuleId{ get; set; }

        /// <summary>
        /// 云厂商
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// 风险名称
        /// </summary>
        [JsonProperty("RiskName")]
        public string RiskName{ get; set; }

        /// <summary>
        /// 风险危害
        /// </summary>
        [JsonProperty("RiskInfluence")]
        public string RiskInfluence{ get; set; }

        /// <summary>
        /// 修复指引
        /// </summary>
        [JsonProperty("RiskFixAdvice")]
        public string RiskFixAdvice{ get; set; }

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
            this.SetParamSimple(map, prefix + "RiskRuleId", this.RiskRuleId);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "RiskName", this.RiskName);
            this.SetParamSimple(map, prefix + "RiskInfluence", this.RiskInfluence);
            this.SetParamSimple(map, prefix + "RiskFixAdvice", this.RiskFixAdvice);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

