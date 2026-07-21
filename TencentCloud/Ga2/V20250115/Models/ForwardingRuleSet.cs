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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ForwardingRuleSet : AbstractModel
    {
        
        /// <summary>
        /// <p>七层转发规则条件信息。</p>
        /// </summary>
        [JsonProperty("RuleCondition")]
        public RuleCondition[] RuleCondition{ get; set; }

        /// <summary>
        /// <p>七层转发规则行为信息。</p>
        /// </summary>
        [JsonProperty("RuleAction")]
        public RuleAction[] RuleAction{ get; set; }

        /// <summary>
        /// <p>是否开启回源Sni。</p>
        /// </summary>
        [JsonProperty("EnableOriginSni")]
        public bool? EnableOriginSni{ get; set; }

        /// <summary>
        /// <p>回源Sni。</p>
        /// </summary>
        [JsonProperty("OriginSni")]
        public string OriginSni{ get; set; }

        /// <summary>
        /// <p>回源Herder信息。</p>
        /// </summary>
        [JsonProperty("OriginHeaders")]
        public OriginHeader[] OriginHeaders{ get; set; }

        /// <summary>
        /// <p>回源Host。</p>
        /// </summary>
        [JsonProperty("OriginHost")]
        public string OriginHost{ get; set; }

        /// <summary>
        /// <p>全球加速实例ID。</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// <p>监听器ID。</p>
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// <p>七层转发策略ID。</p>
        /// </summary>
        [JsonProperty("ForwardingPolicyId")]
        public string ForwardingPolicyId{ get; set; }

        /// <summary>
        /// <p>七层转发规则ID。</p>
        /// </summary>
        [JsonProperty("ForwardingRuleId")]
        public string ForwardingRuleId{ get; set; }

        /// <summary>
        /// <p>源站响应头</p>
        /// </summary>
        [JsonProperty("HideResponseHeaders")]
        public HideResponseHeaders[] HideResponseHeaders{ get; set; }

        /// <summary>
        /// <p>删除源站响应头</p>
        /// </summary>
        [JsonProperty("ResponseHeaders")]
        public ResponseHeaders[] ResponseHeaders{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "RuleCondition.", this.RuleCondition);
            this.SetParamArrayObj(map, prefix + "RuleAction.", this.RuleAction);
            this.SetParamSimple(map, prefix + "EnableOriginSni", this.EnableOriginSni);
            this.SetParamSimple(map, prefix + "OriginSni", this.OriginSni);
            this.SetParamArrayObj(map, prefix + "OriginHeaders.", this.OriginHeaders);
            this.SetParamSimple(map, prefix + "OriginHost", this.OriginHost);
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ForwardingPolicyId", this.ForwardingPolicyId);
            this.SetParamSimple(map, prefix + "ForwardingRuleId", this.ForwardingRuleId);
            this.SetParamArrayObj(map, prefix + "HideResponseHeaders.", this.HideResponseHeaders);
            this.SetParamArrayObj(map, prefix + "ResponseHeaders.", this.ResponseHeaders);
        }
    }
}

