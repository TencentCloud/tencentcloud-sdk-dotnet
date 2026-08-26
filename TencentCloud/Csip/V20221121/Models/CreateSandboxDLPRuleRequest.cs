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

    public class CreateSandboxDLPRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>规则名称<br>入参限制：长度 1-128</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>规则级别<br>枚举值：<br>INFO：提示<br>LOW：低危<br>MEDIUM：中危<br>HIGH：高危<br>CRITICAL：严重</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>规则动作<br>枚举值：<br>PASS：加白<br>BLOCK：拦截并告警<br>MONITOR：告警</p>
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// <p>归属资产类型<br>枚举值：<br>HOST：主机<br>CONTAINER：容器</p>
        /// </summary>
        [JsonProperty("BelongAssetType")]
        public string BelongAssetType{ get; set; }

        /// <summary>
        /// <p>生效范围</p>
        /// </summary>
        [JsonProperty("EffectScope")]
        public TrafficSandboxEffectScope EffectScope{ get; set; }

        /// <summary>
        /// <p>初始状态<br>枚举值：<br>ON：启用<br>OFF：禁用</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>引用的系统规则 ID 列表<br>入参限制：最多 1000 个；与 UserRuleContent 至少提供其一</p>
        /// </summary>
        [JsonProperty("SystemRuleIDList")]
        public long?[] SystemRuleIDList{ get; set; }

        /// <summary>
        /// <p>用户自定义规则内容<br>入参限制：最多 100 条子规则；与 UserRuleInfo 二选一传入即可，二者同时传入时以 UserRuleInfo 为准</p>
        /// </summary>
        [JsonProperty("UserRuleContent")]
        public TrafficSandboxDLPRuleContentItem[] UserRuleContent{ get; set; }

        /// <summary>
        /// <p>新增可选的结构化入参，支持 5 个检测维度（文件名称/文件大小/文件格式/外发域名/外发内容），各维度可选、至少命中一项。与 UserRuleContent 同时传入时优先生效</p>
        /// </summary>
        [JsonProperty("UserRuleInfo")]
        public TrafficSandboxDLPUserRuleInfo UserRuleInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "BelongAssetType", this.BelongAssetType);
            this.SetParamObj(map, prefix + "EffectScope.", this.EffectScope);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "SystemRuleIDList.", this.SystemRuleIDList);
            this.SetParamArrayObj(map, prefix + "UserRuleContent.", this.UserRuleContent);
            this.SetParamObj(map, prefix + "UserRuleInfo.", this.UserRuleInfo);
        }
    }
}

