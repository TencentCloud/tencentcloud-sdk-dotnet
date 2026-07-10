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

    public class DeleteSecurityPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 安全策略 ID 列表，ID 格式为 tls- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("SecurityPolicyIds")]
        public string[] SecurityPolicyIds{ get; set; }

        /// <summary>
        /// 是否仅执行预检请求。取值：
        /// - **true**：仅执行预检请求，不实际删除资源。预检请求将验证参数格式、权限及安全策略是否被引用等，帮助您在正式操作前发现潜在问题。
        /// - **false**（默认）：执行正常请求，通过预检后将直接删除安全策略。
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SecurityPolicyIds.", this.SecurityPolicyIds);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

