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

    public class CustomRule : AbstractModel
    {
        
        /// <summary>
        /// 自定义规则的名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 自定义规则的具体内容，需符合表达式语法，详细规范参见 [产品文档](https://cloud.tencent.com/document/product/1552/125343) 。
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// 自定义规则的处置动作。SecurityAction.Name 取值范围如下：<ul><li>Deny：拦截；</li><li>Monitor：观察；</li><li>ReturnCustomPage：使用指定页面拦截；</li><li>Redirect：重定向至 URL；</li><li>BlockIP：IP 封禁；</li><li>JSChallenge：JavaScript 挑战；</li><li>ManagedChallenge：托管挑战；</li><li>Allow：放行。</li></ul>
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }

        /// <summary>
        /// 自定义规则是否开启。取值有：<ul><li>on：开启</li><li>off：关闭</li></ul>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// 自定义规则的 ID。通过规则 ID 可支持不同的规则配置操作：<ul><li>增加新规则：ID 为空或不指定 ID 参数；</li><li>修改已有规则：指定需要更新/修改的规则 ID；</li><li>删除已有规则：CustomRules 参数中，Rules 列表中未包含的已有规则将被删除。</li></ul>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 自定义规则的类型。取值有：<ul><li>BasicAccessRule：基础访问管控；</li><li>PreciseMatchRule：精准匹配规则；</li><li>ManagedAccessRule：专家定制规则，仅出参支持。</li></ul>说明：当未指定 RuleType 时，默认为 `PreciseMatchRule`。
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 自定义规则的优先级，范围是 0 ~ 100，默认为 0，仅支持精准匹配规则（`PreciseMatchRule`）。
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamObj(map, prefix + "Action.", this.Action);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
        }
    }
}

