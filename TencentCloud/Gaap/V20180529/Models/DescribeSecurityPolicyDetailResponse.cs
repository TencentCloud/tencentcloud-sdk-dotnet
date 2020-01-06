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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSecurityPolicyDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 通道ID
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 安全策略状态：
        /// BOUND，已开启安全策略
        /// UNBIND，已关闭安全策略
        /// BINDING，安全策略开启中
        /// UNBINDING，安全策略关闭中。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 默认策略：ACCEPT或DROP。
        /// </summary>
        [JsonProperty("DefaultAction")]
        public string DefaultAction{ get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// 规则列表
        /// </summary>
        [JsonProperty("RuleList")]
        public SecurityPolicyRuleOut[] RuleList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DefaultAction", this.DefaultAction);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamArrayObj(map, prefix + "RuleList.", this.RuleList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

