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

    public class CreateSandboxLLMAuditRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则名称
        /// 入参限制：长度 1-128
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
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 归属资产类型
        /// 枚举值：
        /// HOST：主机
        /// CONTAINER：容器
        /// </summary>
        [JsonProperty("BelongAssetType")]
        public string BelongAssetType{ get; set; }

        /// <summary>
        /// 引用的 LLM 审计系统规则 ID 列表（字符串，由 DescribeSandboxLLMAuditSystemRuleList 返回的 LLMRules[].RuleID / ToolCallRules[].RuleID 提供）
        /// 入参限制：非空，最多 1000 个；单个元素长度 1-128
        /// </summary>
        [JsonProperty("SystemRuleIDList")]
        public string[] SystemRuleIDList{ get; set; }

        /// <summary>
        /// 生效范围
        /// </summary>
        [JsonProperty("EffectScope")]
        public TrafficSandboxEffectScope EffectScope{ get; set; }

        /// <summary>
        /// 初始状态
        /// 枚举值：
        /// ON：启用
        /// OFF：禁用
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 规则动作(RuleAction)
        /// 枚举值：
        /// PASS：加白
        /// BLOCK：拦截并告警
        /// MONITOR：告警
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "BelongAssetType", this.BelongAssetType);
            this.SetParamArraySimple(map, prefix + "SystemRuleIDList.", this.SystemRuleIDList);
            this.SetParamObj(map, prefix + "EffectScope.", this.EffectScope);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
        }
    }
}

