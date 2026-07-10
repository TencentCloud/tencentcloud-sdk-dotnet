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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSecurityPoliciesResponse : AbstractModel
    {
        
        /// <summary>
        /// 下一页查询的起始令牌。
        /// 
        /// - 若返回值不为空，表示还有更多数据，可将此值作为下一次请求的 NextToken 参数继续查询。
        /// - 若返回值为空或未返回此字段，表示已是最后一页。
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// 安全策略信息列表。包含每个安全策略的详细配置，如策略 ID、名称、TLS 版本、加密套件等。
        /// </summary>
        [JsonProperty("SecurityPolicies")]
        public SecurityPolicyInfo[] SecurityPolicies{ get; set; }

        /// <summary>
        /// 符合过滤条件的安全策略总数。
        /// 
        /// **说明：** 此值表示满足查询条件的总记录数，而非本次返回的记录数。可用于计算分页信息。
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamArrayObj(map, prefix + "SecurityPolicies.", this.SecurityPolicies);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

