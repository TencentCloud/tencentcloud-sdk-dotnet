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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateConfigRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 触发类型，最多支持两种
        /// </summary>
        [JsonProperty("TriggerType")]
        public TriggerType[] TriggerType{ get; set; }

        /// <summary>
        /// 风险等级
        /// 1：高风险。
        /// 2：中风险。
        /// 3：低风险。
        /// </summary>
        [JsonProperty("RiskLevel")]
        public ulong? RiskLevel{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 入参
        /// </summary>
        [JsonProperty("InputParameter")]
        public InputParameter[] InputParameter{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 规则评估地域范围，规则仅对指定地域中的资源生效。
        /// 支持的地域范围config:ListResourceRegions返回的地域
        /// </summary>
        [JsonProperty("RegionsScope")]
        public string[] RegionsScope{ get; set; }

        /// <summary>
        /// 规则评估标签范围，规则仅对绑定指定标签的资源生效。
        /// </summary>
        [JsonProperty("TagsScope")]
        public Tag[] TagsScope{ get; set; }

        /// <summary>
        /// 规则对指定资源ID无效，即不对该资源执行评估。
        /// </summary>
        [JsonProperty("ExcludeResourceIdsScope")]
        public string[] ExcludeResourceIdsScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TriggerType.", this.TriggerType);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArrayObj(map, prefix + "InputParameter.", this.InputParameter);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "RegionsScope.", this.RegionsScope);
            this.SetParamArrayObj(map, prefix + "TagsScope.", this.TagsScope);
            this.SetParamArraySimple(map, prefix + "ExcludeResourceIdsScope.", this.ExcludeResourceIdsScope);
        }
    }
}

