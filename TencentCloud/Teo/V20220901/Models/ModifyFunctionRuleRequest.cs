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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyFunctionRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 规则 ID。您可以先通过 DescribeFunctionRules 接口来获取需要修改的规则的 RuleId，然后传入修改后的规则内容，原规则内容会被覆盖式更新。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 规则条件列表，相同触发规则的不同条件匹配项之间为或关系，不填写保持原有配置。
        /// </summary>
        [JsonProperty("FunctionRuleConditions")]
        public FunctionRuleCondition[] FunctionRuleConditions{ get; set; }

        /// <summary>
        /// 函数选择配置类型：
        /// <li> direct：直接指定执行函数；</li>
        /// <li> weight：基于权重比选择函数；</li>
        /// <li> region：基于客户端 IP 的国家/地区选择函数。</li>
        /// 不填时默认为 direct 。
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// 指定执行的函数 ID。当 TriggerType 为 direct 或 TriggerType 不填时生效。
        /// </summary>
        [JsonProperty("FunctionId")]
        public string FunctionId{ get; set; }

        /// <summary>
        /// 基于客户端 IP 国家/地区的函数选择配置，当 TriggerType 为 region 时生效且 RegionMappingSelections 必填。RegionMappingSelections 中至少包含一项 Regions 为 Default 的配置。
        /// </summary>
        [JsonProperty("RegionMappingSelections")]
        public FunctionRegionSelection[] RegionMappingSelections{ get; set; }

        /// <summary>
        /// 基于权重的函数选择配置，当 TriggerType 为 weight 时生效且 WeightedSelections 必填。WeightedSelections 中的所有权重之和需要为100。
        /// </summary>
        [JsonProperty("WeightedSelections")]
        public FunctionWeightedSelection[] WeightedSelections{ get; set; }

        /// <summary>
        /// 规则描述，最大支持 60 个字符，不填写保持原有配置。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamArrayObj(map, prefix + "FunctionRuleConditions.", this.FunctionRuleConditions);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "FunctionId", this.FunctionId);
            this.SetParamArrayObj(map, prefix + "RegionMappingSelections.", this.RegionMappingSelections);
            this.SetParamArrayObj(map, prefix + "WeightedSelections.", this.WeightedSelections);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

