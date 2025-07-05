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

    public class ManagedRuleGroup : AbstractModel
    {
        
        /// <summary>
        /// 托管规则的组名称，未指定配置的规则分组将按照默认配置处理，GroupId 的具体取值参考产品文档。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 托管规则组的防护级别。取值有：<li>loose：宽松，只包含超高风险规则，此时需配置Action，且RuleActions配置无效；</li><li>normal：正常，包含超高风险和高风险规则，此时需配置Action，且RuleActions配置无效；</li><li>strict：严格，包含超高风险、高风险和中风险规则，此时需配置Action，且RuleActions配置无效；</li><li>extreme：超严格，包含超高风险、高风险、中风险和低风险规则，此时需配置Action，且RuleActions配置无效；</li><li>custom：自定义，精细化策略，按单条规则配置处置方式，此时Action字段无效，使用RuleActions配置单条规则的精细化策略。</li>	
        /// </summary>
        [JsonProperty("SensitivityLevel")]
        public string SensitivityLevel{ get; set; }

        /// <summary>
        /// 托管规则组的处置动作。SecurityAction 的 Name 取值支持：<li>Deny：拦截，响应拦截页面；</li><li>Monitor：观察，不处理请求记录安全事件到日志中；</li><li>Disabled：未启用，不扫描请求跳过该规则。</li>
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }

        /// <summary>
        /// 托管规则组下规则项的具体配置，仅在 SensitivityLevel 为 custom 时配置生效。
        /// </summary>
        [JsonProperty("RuleActions")]
        public ManagedRuleAction[] RuleActions{ get; set; }

        /// <summary>
        /// 托管规则组信息，仅出参。	
        /// </summary>
        [JsonProperty("MetaData")]
        public ManagedRuleGroupMeta MetaData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "SensitivityLevel", this.SensitivityLevel);
            this.SetParamObj(map, prefix + "Action.", this.Action);
            this.SetParamArrayObj(map, prefix + "RuleActions.", this.RuleActions);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
        }
    }
}

