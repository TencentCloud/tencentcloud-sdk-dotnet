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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySandboxACLRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则 ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 规则名称
        /// 入参限制：长度 1-128
        /// 默认值：不传则不修改
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则级别
        /// 枚举值：
        /// INFO：提示
        /// LOW：低危
        /// MEDIUM：中危
        /// HIGH：高危
        /// CRITICAL：严重
        /// 默认值：不传则不修改
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 引用的系统规则 ID 列表
        /// 入参限制：传空数组表示清空；不传表示不修改
        /// </summary>
        [JsonProperty("SystemRuleIDList")]
        public long?[] SystemRuleIDList{ get; set; }

        /// <summary>
        /// 用户自定义规则内容
        /// 入参限制：传空数组表示清空；不传表示不修改
        /// </summary>
        [JsonProperty("UserRuleContent")]
        public TrafficSandboxACLRuleContentItem[] UserRuleContent{ get; set; }

        /// <summary>
        /// 生效范围
        /// 默认值：不传则不修改
        /// </summary>
        [JsonProperty("EffectScope")]
        public TrafficSandboxEffectScope EffectScope{ get; set; }

        /// <summary>
        /// 规则动作(RuleAction)
        /// 枚举值：
        /// PASS：加白
        /// BLOCK：拦截并告警
        /// MONITOR：告警
        /// 默认值：不传则不修改
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// 目标状态
        /// 枚举值：
        /// ON：启用
        /// OFF：禁用
        /// 默认值：不传则不修改
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamArraySimple(map, prefix + "SystemRuleIDList.", this.SystemRuleIDList);
            this.SetParamArrayObj(map, prefix + "UserRuleContent.", this.UserRuleContent);
            this.SetParamObj(map, prefix + "EffectScope.", this.EffectScope);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

