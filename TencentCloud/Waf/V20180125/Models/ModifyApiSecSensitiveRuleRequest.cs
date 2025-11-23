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
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 1表示开，0表示关，3表示删除
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 客户自定义配置
        /// </summary>
        [JsonProperty("CustomRule")]
        public ApiSecCustomSensitiveRule CustomRule{ get; set; }

        /// <summary>
        /// rulename列表，批量操作的时候填改值
        /// </summary>
        [JsonProperty("RuleNameList")]
        public string[] RuleNameList{ get; set; }

        /// <summary>
        /// api提取规则内容
        /// </summary>
        [JsonProperty("CustomApiExtractRule")]
        public ApiSecExtractRule CustomApiExtractRule{ get; set; }

        /// <summary>
        /// 批量操作的时候的api提取规则
        /// </summary>
        [JsonProperty("ApiExtractRuleName")]
        public string[] ApiExtractRuleName{ get; set; }

        /// <summary>
        /// 自定义api鉴权规则
        /// </summary>
        [JsonProperty("ApiSecPrivilegeRule")]
        public ApiSecPrivilegeRule ApiSecPrivilegeRule{ get; set; }

        /// <summary>
        /// 匹配操作时候的api鉴权规则
        /// </summary>
        [JsonProperty("ApiSecPrivilegeRuleName")]
        public string[] ApiSecPrivilegeRuleName{ get; set; }

        /// <summary>
        /// 批量操作的时候的自定义场景列表
        /// </summary>
        [JsonProperty("ApiSecSceneRuleNameList")]
        public string[] ApiSecSceneRuleNameList{ get; set; }

        /// <summary>
        /// 单条自定义api场景规则
        /// </summary>
        [JsonProperty("ApiSecSceneRule")]
        public ApiSecSceneRule ApiSecSceneRule{ get; set; }

        /// <summary>
        /// 批量操作的时候的自定义事件规则列表
        /// </summary>
        [JsonProperty("ApiSecCustomEventRuleNameList")]
        public string[] ApiSecCustomEventRuleNameList{ get; set; }

        /// <summary>
        /// 自定义事件规则
        /// </summary>
        [JsonProperty("ApiSecCustomEventRuleRule")]
        public ApiSecCustomEventRule ApiSecCustomEventRuleRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamObj(map, prefix + "CustomRule.", this.CustomRule);
            this.SetParamArraySimple(map, prefix + "RuleNameList.", this.RuleNameList);
            this.SetParamObj(map, prefix + "CustomApiExtractRule.", this.CustomApiExtractRule);
            this.SetParamArraySimple(map, prefix + "ApiExtractRuleName.", this.ApiExtractRuleName);
            this.SetParamObj(map, prefix + "ApiSecPrivilegeRule.", this.ApiSecPrivilegeRule);
            this.SetParamArraySimple(map, prefix + "ApiSecPrivilegeRuleName.", this.ApiSecPrivilegeRuleName);
            this.SetParamArraySimple(map, prefix + "ApiSecSceneRuleNameList.", this.ApiSecSceneRuleNameList);
            this.SetParamObj(map, prefix + "ApiSecSceneRule.", this.ApiSecSceneRule);
            this.SetParamArraySimple(map, prefix + "ApiSecCustomEventRuleNameList.", this.ApiSecCustomEventRuleNameList);
            this.SetParamObj(map, prefix + "ApiSecCustomEventRuleRule.", this.ApiSecCustomEventRuleRule);
        }
    }
}

