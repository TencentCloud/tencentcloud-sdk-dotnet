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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PolicyRoutePreCheckReport : AbstractModel
    {
        
        /// <summary>
        /// 本次编排生成的下一跳数量
        /// </summary>
        [JsonProperty("NextHopCount")]
        public long? NextHopCount{ get; set; }

        /// <summary>
        /// 下一跳上限
        /// </summary>
        [JsonProperty("NextHopLimit")]
        public long? NextHopLimit{ get; set; }

        /// <summary>
        /// 本次编排生成的匹配规则数
        /// </summary>
        [JsonProperty("MatchRuleCount")]
        public long? MatchRuleCount{ get; set; }

        /// <summary>
        /// 匹配规则上限
        /// </summary>
        [JsonProperty("MatchRuleLimit")]
        public long? MatchRuleLimit{ get; set; }

        /// <summary>
        /// 云上已有匹配规则数（其他防火墙类型占用）
        /// </summary>
        [JsonProperty("CloudExistingRuleCount")]
        public long? CloudExistingRuleCount{ get; set; }

        /// <summary>
        /// 云上已有下一跳数（其他防火墙类型占用）
        /// </summary>
        [JsonProperty("CloudExistingNextHopCount")]
        public long? CloudExistingNextHopCount{ get; set; }

        /// <summary>
        /// 可用匹配规则配额 = MatchRuleLimit - CloudExistingRuleCount - MatchRuleCount
        /// </summary>
        [JsonProperty("AvailableRuleQuota")]
        public long? AvailableRuleQuota{ get; set; }

        /// <summary>
        /// 可用下一跳配额 = NextHopLimit - CloudExistingNextHopCount - NextHopCount
        /// </summary>
        [JsonProperty("AvailableNextHopQuota")]
        public long? AvailableNextHopQuota{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NextHopCount", this.NextHopCount);
            this.SetParamSimple(map, prefix + "NextHopLimit", this.NextHopLimit);
            this.SetParamSimple(map, prefix + "MatchRuleCount", this.MatchRuleCount);
            this.SetParamSimple(map, prefix + "MatchRuleLimit", this.MatchRuleLimit);
            this.SetParamSimple(map, prefix + "CloudExistingRuleCount", this.CloudExistingRuleCount);
            this.SetParamSimple(map, prefix + "CloudExistingNextHopCount", this.CloudExistingNextHopCount);
            this.SetParamSimple(map, prefix + "AvailableRuleQuota", this.AvailableRuleQuota);
            this.SetParamSimple(map, prefix + "AvailableNextHopQuota", this.AvailableNextHopQuota);
        }
    }
}

