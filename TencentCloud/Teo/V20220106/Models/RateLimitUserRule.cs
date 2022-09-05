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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RateLimitUserRule : AbstractModel
    {
        
        /// <summary>
        /// RateLimit统计阈值，单位是次，取值范围0-4294967294。
        /// </summary>
        [JsonProperty("Threshold")]
        public long? Threshold{ get; set; }

        /// <summary>
        /// RateLimit统计时间，取值范围 10/20/30/40/50/60 单位是秒。
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 规则名，只能以英文字符，数字，下划线组合，且不能以下划线开头。
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 处置动作。
        /// 1. monitor(观察)；
        /// 2. drop(拦截)；
        /// 3. alg(Javascript挑战)
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 惩罚时长，0-100。
        /// </summary>
        [JsonProperty("PunishTime")]
        public long? PunishTime{ get; set; }

        /// <summary>
        /// 处罚时长单位。
        /// 1. second 秒; 
        /// 2. minutes 分钟
        /// 3. hour 小时
        /// </summary>
        [JsonProperty("PunishTimeUnit")]
        public string PunishTimeUnit{ get; set; }

        /// <summary>
        /// 规则状态。
        /// 1. on 生效
        /// 2. off 不生效
        /// </summary>
        [JsonProperty("RuleStatus")]
        public string RuleStatus{ get; set; }

        /// <summary>
        /// 规则。
        /// </summary>
        [JsonProperty("Conditions")]
        public ACLCondition[] Conditions{ get; set; }

        /// <summary>
        /// 规则权重，取值范围0-100。
        /// </summary>
        [JsonProperty("RulePriority")]
        public long? RulePriority{ get; set; }

        /// <summary>
        /// 规则id。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// 过滤词。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FreqFields")]
        public string[] FreqFields{ get; set; }

        /// <summary>
        /// 更新时间.
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "PunishTime", this.PunishTime);
            this.SetParamSimple(map, prefix + "PunishTimeUnit", this.PunishTimeUnit);
            this.SetParamSimple(map, prefix + "RuleStatus", this.RuleStatus);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamSimple(map, prefix + "RulePriority", this.RulePriority);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArraySimple(map, prefix + "FreqFields.", this.FreqFields);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

