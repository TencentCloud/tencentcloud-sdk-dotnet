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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateOrganizationMembersPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 成员Uin列表。最多10个
        /// </summary>
        [JsonProperty("MemberUins")]
        public long?[] MemberUins{ get; set; }

        /// <summary>
        /// 成员访问策略Id。可通过DescribeOrganizationMemberPolicies获取
        /// </summary>
        [JsonProperty("PolicyId")]
        public ulong? PolicyId{ get; set; }

        /// <summary>
        /// 成员访问身份ID。可通过ListOrganizationIdentity获取
        /// </summary>
        [JsonProperty("IdentityId")]
        public long? IdentityId{ get; set; }

        /// <summary>
        /// 策略描述。最大长度为128个字符
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberUins.", this.MemberUins);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "IdentityId", this.IdentityId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

