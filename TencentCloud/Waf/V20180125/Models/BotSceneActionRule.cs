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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BotSceneActionRule : AbstractModel
    {
        
        /// <summary>
        /// 动作策略ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 动作策略名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 策略优先级
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 策略生效状态
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// 分数范围
        /// </summary>
        [JsonProperty("Score")]
        public BotScoreRuleEntry[] Score{ get; set; }

        /// <summary>
        /// 100-宽松、200-中等、300-严格、0-自定义
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 生效范围，为空表示全部范围
        /// </summary>
        [JsonProperty("Scope")]
        public BotActionScopeRuleEntry[] Scope{ get; set; }

        /// <summary>
        /// default：默认创建 custom：自定义创建
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 匹配范围类型：全局匹配 or 自定义匹配范围
        /// </summary>
        [JsonProperty("ScopeType")]
        public string ScopeType{ get; set; }

        /// <summary>
        /// 匹配条件间的与或关系
        /// </summary>
        [JsonProperty("ActionMatchType")]
        public string ActionMatchType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Score.", this.Score);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamArrayObj(map, prefix + "Scope.", this.Scope);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ScopeType", this.ScopeType);
            this.SetParamSimple(map, prefix + "ActionMatchType", this.ActionMatchType);
        }
    }
}

