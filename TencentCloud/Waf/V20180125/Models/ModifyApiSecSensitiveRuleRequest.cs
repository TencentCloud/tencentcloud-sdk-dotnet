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

    public class ModifyApiSecSensitiveRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>1表示开，0表示关，3表示删除</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>规则名称</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>rulename列表，批量操作的时候填改值</p>
        /// </summary>
        [JsonProperty("RuleNameList")]
        public string[] RuleNameList{ get; set; }

        /// <summary>
        /// <p>客户自定义配置</p>
        /// </summary>
        [JsonProperty("CustomRule")]
        public ApiSecCustomSensitiveRule CustomRule{ get; set; }

        /// <summary>
        /// <p>批量操作的时候的api提取规则</p>
        /// </summary>
        [JsonProperty("ApiExtractRuleName")]
        public string[] ApiExtractRuleName{ get; set; }

        /// <summary>
        /// <p>api提取规则内容</p>
        /// </summary>
        [JsonProperty("CustomApiExtractRule")]
        public ApiSecExtractRule CustomApiExtractRule{ get; set; }

        /// <summary>
        /// <p>匹配操作时候的api鉴权规则</p>
        /// </summary>
        [JsonProperty("ApiSecPrivilegeRuleName")]
        public string[] ApiSecPrivilegeRuleName{ get; set; }

        /// <summary>
        /// <p>自定义api鉴权规则</p>
        /// </summary>
        [JsonProperty("ApiSecPrivilegeRule")]
        public ApiSecPrivilegeRule ApiSecPrivilegeRule{ get; set; }

        /// <summary>
        /// <p>批量操作的时候的自定义场景列表</p>
        /// </summary>
        [JsonProperty("ApiSecSceneRuleNameList")]
        public string[] ApiSecSceneRuleNameList{ get; set; }

        /// <summary>
        /// <p>单条自定义api场景规则</p>
        /// </summary>
        [JsonProperty("ApiSecSceneRule")]
        public ApiSecSceneRule ApiSecSceneRule{ get; set; }

        /// <summary>
        /// <p>批量操作的时候的自定义事件规则列表</p>
        /// </summary>
        [JsonProperty("ApiSecCustomEventRuleNameList")]
        public string[] ApiSecCustomEventRuleNameList{ get; set; }

        /// <summary>
        /// <p>自定义事件规则</p>
        /// </summary>
        [JsonProperty("ApiSecCustomEventRuleRule")]
        public ApiSecCustomEventRule ApiSecCustomEventRuleRule{ get; set; }

        /// <summary>
        /// <p>批量操作的时候的无效api排除规则</p>
        /// </summary>
        [JsonProperty("ApiExcludeRuleName")]
        public string[] ApiExcludeRuleName{ get; set; }

        /// <summary>
        /// <p>无效api排除规则</p>
        /// </summary>
        [JsonProperty("CustomApiExcludeRule")]
        public ApiSecExcludeRule CustomApiExcludeRule{ get; set; }

        /// <summary>
        /// <p>批量操作时的敏感数据加白规则名称列表</p>
        /// </summary>
        [JsonProperty("ApiSecSensitiveWhiteRuleNameList")]
        public string[] ApiSecSensitiveWhiteRuleNameList{ get; set; }

        /// <summary>
        /// <p>敏感数据加白规则</p>
        /// </summary>
        [JsonProperty("ApiSecSensitiveWhiteRuleRule")]
        public ApiSecSensitiveWhiteRule ApiSecSensitiveWhiteRuleRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArraySimple(map, prefix + "RuleNameList.", this.RuleNameList);
            this.SetParamObj(map, prefix + "CustomRule.", this.CustomRule);
            this.SetParamArraySimple(map, prefix + "ApiExtractRuleName.", this.ApiExtractRuleName);
            this.SetParamObj(map, prefix + "CustomApiExtractRule.", this.CustomApiExtractRule);
            this.SetParamArraySimple(map, prefix + "ApiSecPrivilegeRuleName.", this.ApiSecPrivilegeRuleName);
            this.SetParamObj(map, prefix + "ApiSecPrivilegeRule.", this.ApiSecPrivilegeRule);
            this.SetParamArraySimple(map, prefix + "ApiSecSceneRuleNameList.", this.ApiSecSceneRuleNameList);
            this.SetParamObj(map, prefix + "ApiSecSceneRule.", this.ApiSecSceneRule);
            this.SetParamArraySimple(map, prefix + "ApiSecCustomEventRuleNameList.", this.ApiSecCustomEventRuleNameList);
            this.SetParamObj(map, prefix + "ApiSecCustomEventRuleRule.", this.ApiSecCustomEventRuleRule);
            this.SetParamArraySimple(map, prefix + "ApiExcludeRuleName.", this.ApiExcludeRuleName);
            this.SetParamObj(map, prefix + "CustomApiExcludeRule.", this.CustomApiExcludeRule);
            this.SetParamArraySimple(map, prefix + "ApiSecSensitiveWhiteRuleNameList.", this.ApiSecSensitiveWhiteRuleNameList);
            this.SetParamObj(map, prefix + "ApiSecSensitiveWhiteRuleRule.", this.ApiSecSensitiveWhiteRuleRule);
        }
    }
}

