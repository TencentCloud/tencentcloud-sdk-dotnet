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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AllocationRulesSummary : AbstractModel
    {
        
        /// <summary>
        /// 新增公摊规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 公摊策略类型，枚举值如下：
        /// 1 - 自定义分摊占比 
        /// 2 - 等比分摊
        /// 3 - 按占比分摊
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 公摊规则表达式
        /// </summary>
        [JsonProperty("RuleDetail")]
        public AllocationRuleExpression RuleDetail{ get; set; }

        /// <summary>
        /// 公摊比例表达式，按占比分摊不传
        /// </summary>
        [JsonProperty("RatioDetail")]
        public AllocationRationExpression[] RatioDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "RuleDetail.", this.RuleDetail);
            this.SetParamArrayObj(map, prefix + "RatioDetail.", this.RatioDetail);
        }
    }
}

