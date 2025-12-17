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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReplaceSecurityGroupPoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// 安全组实例ID，例如sg-33ocnj9n，可通过<a href="https://cloud.tencent.com/document/product/215/15808">DescribeSecurityGroups</a>获取。
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// 安全组规则集合对象。
        /// </summary>
        [JsonProperty("SecurityGroupPolicySet")]
        public SecurityGroupPolicySet SecurityGroupPolicySet{ get; set; }

        /// <summary>
        /// 旧的安全组规则集合对象，当更新优先级时为必选，且修改顺序与SecurityGroupPolicySet参数顺序一一对应，入参长度需要与SecurityGroupPolicySet参数保持一致。
        /// </summary>
        [JsonProperty("OriginalSecurityGroupPolicySet")]
        public SecurityGroupPolicySet OriginalSecurityGroupPolicySet{ get; set; }

        /// <summary>
        /// 更新类型，默认 Policy  Policy：只更新内容  Priority：只更新优先级  Both：内容和优先级都更新
        /// </summary>
        [JsonProperty("UpdateType")]
        public string UpdateType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamObj(map, prefix + "SecurityGroupPolicySet.", this.SecurityGroupPolicySet);
            this.SetParamObj(map, prefix + "OriginalSecurityGroupPolicySet.", this.OriginalSecurityGroupPolicySet);
            this.SetParamSimple(map, prefix + "UpdateType", this.UpdateType);
        }
    }
}

