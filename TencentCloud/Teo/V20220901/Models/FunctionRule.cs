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

    public class FunctionRule : AbstractModel
    {
        
        /// <summary>
        /// 规则ID。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 规则条件列表，列表项之间为或关系。
        /// </summary>
        [JsonProperty("FunctionRuleConditions")]
        public FunctionRuleCondition[] FunctionRuleConditions{ get; set; }

        /// <summary>
        /// 函数选择配置类型：
        /// <li> direct：直接指定执行函数；</li>
        /// <li> weight：基于权重比选择函数；</li>
        /// <li> region：基于客户端 IP 的国家/地区选择函数。</li>
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// 指定执行的函数 ID。当 TriggerType 为 direct 时有效。
        /// </summary>
        [JsonProperty("FunctionId")]
        public string FunctionId{ get; set; }

        /// <summary>
        /// 指定执行的函数名称。
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 基于客户端 IP 国家/地区的函数选择配置。
        /// </summary>
        [JsonProperty("RegionMappingSelections")]
        public FunctionRegionSelection[] RegionMappingSelections{ get; set; }

        /// <summary>
        /// 基于权重的函数选择配置。
        /// </summary>
        [JsonProperty("WeightedSelections")]
        public FunctionWeightedSelection[] WeightedSelections{ get; set; }

        /// <summary>
        /// 函数触发规则优先级，数值越大，优先级越高。
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 规则描述。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 创建时间。时间为世界标准时间（UTC）， 遵循 ISO 8601 标准的日期和时间格式。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间。时间为世界标准时间（UTC）， 遵循 ISO 8601 标准的日期和时间格式。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamArrayObj(map, prefix + "FunctionRuleConditions.", this.FunctionRuleConditions);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "FunctionId", this.FunctionId);
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamArrayObj(map, prefix + "RegionMappingSelections.", this.RegionMappingSelections);
            this.SetParamArrayObj(map, prefix + "WeightedSelections.", this.WeightedSelections);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

