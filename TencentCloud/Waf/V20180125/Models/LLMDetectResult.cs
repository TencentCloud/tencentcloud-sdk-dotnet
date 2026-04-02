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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LLMDetectResult : AbstractModel
    {
        
        /// <summary>
        /// <p>仅输出侧：涉敏信息</p>
        /// </summary>
        [JsonProperty("SensitiveResult")]
        public LLMSensitiveValueLevel[] SensitiveResult{ get; set; }

        /// <summary>
        /// <p>输入输出均检测：关键词库命中信息</p>
        /// </summary>
        [JsonProperty("KeyWordsResult")]
        public KeyWordInfo[] KeyWordsResult{ get; set; }

        /// <summary>
        /// <p>输入输出均检测：数据分类分级结果</p>
        /// </summary>
        [JsonProperty("DataCategoryResult")]
        public string[] DataCategoryResult{ get; set; }

        /// <summary>
        /// <p>仅输入侧检出：prompt检测的结果</p>
        /// </summary>
        [JsonProperty("PromptInjectionResult")]
        public PromptDetectResult PromptInjectionResult{ get; set; }

        /// <summary>
        /// <p>命中的规则ID</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>命中的规则名称</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>规则动作</p>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>攻击payload</p>
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SensitiveResult.", this.SensitiveResult);
            this.SetParamArrayObj(map, prefix + "KeyWordsResult.", this.KeyWordsResult);
            this.SetParamArraySimple(map, prefix + "DataCategoryResult.", this.DataCategoryResult);
            this.SetParamObj(map, prefix + "PromptInjectionResult.", this.PromptInjectionResult);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
        }
    }
}

