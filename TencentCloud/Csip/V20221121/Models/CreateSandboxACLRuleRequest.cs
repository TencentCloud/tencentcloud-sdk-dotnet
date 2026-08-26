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

    public class CreateSandboxACLRuleRequest : AbstractModel
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
        /// 生效范围
        /// 入参限制：EffectScope.EffectType=INCLUDE 时 EffectAssets 必须非空
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
        /// 引用的系统规则 ID 列表
        /// 入参限制：最多 100 个；与 UserRuleContent 至少提供其一
        /// </summary>
        [JsonProperty("SystemRuleIDList")]
        public long?[] SystemRuleIDList{ get; set; }

        /// <summary>
        /// 用户自定义规则内容
        /// 入参限制：最多 100 条子规则；与 SystemRuleIDList 至少提供其一
        /// </summary>
        [JsonProperty("UserRuleContent")]
        public TrafficSandboxACLRuleContentItem[] UserRuleContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "BelongAssetType", this.BelongAssetType);
            this.SetParamObj(map, prefix + "EffectScope.", this.EffectScope);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamArraySimple(map, prefix + "SystemRuleIDList.", this.SystemRuleIDList);
            this.SetParamArrayObj(map, prefix + "UserRuleContent.", this.UserRuleContent);
        }
    }
}

