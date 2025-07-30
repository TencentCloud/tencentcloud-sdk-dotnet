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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSubAccountLoginIpPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// IP策略集合
        /// </summary>
        [JsonProperty("IpPolicies")]
        public IpPolicy[] IpPolicies{ get; set; }

        /// <summary>
        /// 审批人类型，目前支持的类型有：SubAccountLoginLimitApproval（子账号登录限制审批）
        /// </summary>
        [JsonProperty("ApproverType")]
        public string ApproverType{ get; set; }

        /// <summary>
        /// 被添加为协助审批人的账号ID数组
        /// </summary>
        [JsonProperty("ApproverUin")]
        public ulong?[] ApproverUin{ get; set; }

        /// <summary>
        /// 是否禁用策略：0：不禁用，1：禁用
        /// </summary>
        [JsonProperty("DisablePolicy")]
        public ulong? DisablePolicy{ get; set; }

        /// <summary>
        /// 策略类型：1：更新IP策略，2：设置异地登录校验校验规则
        /// </summary>
        [JsonProperty("PolicyType")]
        public ulong? PolicyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "IpPolicies.", this.IpPolicies);
            this.SetParamSimple(map, prefix + "ApproverType", this.ApproverType);
            this.SetParamArraySimple(map, prefix + "ApproverUin.", this.ApproverUin);
            this.SetParamSimple(map, prefix + "DisablePolicy", this.DisablePolicy);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
        }
    }
}

