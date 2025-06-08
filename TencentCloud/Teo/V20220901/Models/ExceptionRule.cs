/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class ExceptionRule : AbstractModel
    {
        
        /// <summary>
        /// 例外规则的 ID。<br>通过规则 ID 可支持不同的规则配置操作：<br> <li> <b>增加</b>新规则：ID 为空或不指定 ID 参数；</li><li> <b>修改</b>已有规则：指定需要更新/修改的规则 ID；</li><li> <b>删除</b>已有规则：ExceptionRules 参数中，Rules 列表中未包含的已有规则将被删除。</li>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 例外规则的名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 例外规则的具体内容，需符合表达式语法，详细规范参见产品文档。
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// 例外规则执行选项，取值有：<li>WebSecurityModules: 指定例外规则的安全防护模块。</li><li>ManagedRules：指定托管规则。</li>
        /// </summary>
        [JsonProperty("SkipScope")]
        public string SkipScope{ get; set; }

        /// <summary>
        /// 跳过请求的具体类型，取值有：<li>SkipOnAllRequestFields: 跳过所有请求；</li><li>SkipOnSpecifiedRequestFields: 跳过指定请求字段。</li>仅当 SkipScope 为 ManagedRules 时有效。
        /// </summary>
        [JsonProperty("SkipOption")]
        public string SkipOption{ get; set; }

        /// <summary>
        /// 指定例外规则的安全防护模块，仅当 SkipScope 为 WebSecurityModules 时有效。取值有：<li>websec-mod-managed-rules：托管规则；</li><li>websec-mod-rate-limiting：速率限制；</li><li>websec-mod-custom-rules：自定义规则；</li><li>websec-mod-adaptive-control：自适应频控、智能客户端过滤、慢速攻击防护、流量盗刷防护；</li><li>websec-mod-bot：Bot管理。</li>
        /// </summary>
        [JsonProperty("WebSecurityModulesForException")]
        public string[] WebSecurityModulesForException{ get; set; }

        /// <summary>
        /// 指定例外规则的具体托管规则，仅当 SkipScope 为 ManagedRules 时有效，且此时不能指定 ManagedRuleGroupsForException 。
        /// </summary>
        [JsonProperty("ManagedRulesForException")]
        public string[] ManagedRulesForException{ get; set; }

        /// <summary>
        /// 指定例外规则的托管规则组，仅当 SkipScope 为 ManagedRules 时有效，且此时不能指定 ManagedRulesForException 。
        /// </summary>
        [JsonProperty("ManagedRuleGroupsForException")]
        public string[] ManagedRuleGroupsForException{ get; set; }

        /// <summary>
        /// 指定例外规则跳过指定请求字段的具体配置，仅当 SkipScope 为 ManagedRules 并且 SkipOption 为 SkipOnSpecifiedRequestFields 时有效。
        /// </summary>
        [JsonProperty("RequestFieldsForException")]
        public RequestFieldsForException[] RequestFieldsForException{ get; set; }

        /// <summary>
        /// 例外规则是否开启。取值有：<li>on：开启</li><li>off：关闭</li>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "SkipScope", this.SkipScope);
            this.SetParamSimple(map, prefix + "SkipOption", this.SkipOption);
            this.SetParamArraySimple(map, prefix + "WebSecurityModulesForException.", this.WebSecurityModulesForException);
            this.SetParamArraySimple(map, prefix + "ManagedRulesForException.", this.ManagedRulesForException);
            this.SetParamArraySimple(map, prefix + "ManagedRuleGroupsForException.", this.ManagedRuleGroupsForException);
            this.SetParamArrayObj(map, prefix + "RequestFieldsForException.", this.RequestFieldsForException);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

