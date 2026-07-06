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

namespace TencentCloud.Fwm.V20250611.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRiskAnalysisDetailsResponse : AbstractModel
    {
        
        /// <summary>
        /// 风险企业安全组规则列表
        /// </summary>
        [JsonProperty("EnterpriseSecurityGroupRule")]
        public AnalysisSgRuleInfoResp[] EnterpriseSecurityGroupRule{ get; set; }

        /// <summary>
        /// 风险安全组规则列表
        /// </summary>
        [JsonProperty("SecurityGroupPolicy")]
        public SecurityGroupRiskPolicy[] SecurityGroupPolicy{ get; set; }

        /// <summary>
        /// 实时分析状态，1分析执行中请轮询，0分析已结束
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 风险企业安全组IPV6规则列表
        /// </summary>
        [JsonProperty("EnterpriseSecurityGroupRuleIPV6")]
        public AnalysisSgRuleInfoResp[] EnterpriseSecurityGroupRuleIPV6{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "EnterpriseSecurityGroupRule.", this.EnterpriseSecurityGroupRule);
            this.SetParamArrayObj(map, prefix + "SecurityGroupPolicy.", this.SecurityGroupPolicy);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "EnterpriseSecurityGroupRuleIPV6.", this.EnterpriseSecurityGroupRuleIPV6);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

