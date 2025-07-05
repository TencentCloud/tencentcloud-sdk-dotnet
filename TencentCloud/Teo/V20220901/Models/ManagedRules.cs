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

    public class ManagedRules : AbstractModel
    {
        
        /// <summary>
        /// 托管规则是否开启。取值有：<li>on：开启，所有托管规则按配置生效；</li><li>off：关闭，所有托管规则不生效。</li>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// 评估模式是否开启，仅在 Enabled 参数为 on 时有效。取值有：<li>on：开启，表示所有托管规则以观察模式生效；</li><li>off：关闭，表示所有托管规则以实际配置生效。</li>
        /// </summary>
        [JsonProperty("DetectionOnly")]
        public string DetectionOnly{ get; set; }

        /// <summary>
        /// 托管规则语义分析选项是否开启，仅在 Enabled 参数为 on 时有效。取值有：<li>on：开启，对请求进行语义分析后进行处理；</li><li>off：关闭，对请求不进行语义分析，直接进行处理。</li> <br/>默认为 off。
        /// </summary>
        [JsonProperty("SemanticAnalysis")]
        public string SemanticAnalysis{ get; set; }

        /// <summary>
        /// 托管规则自动更新选项。
        /// </summary>
        [JsonProperty("AutoUpdate")]
        public ManagedRuleAutoUpdate AutoUpdate{ get; set; }

        /// <summary>
        /// 托管规则组的配置。如果此结构传空数组或 GroupId 未包含在列表内将按照默认方式处理。
        /// </summary>
        [JsonProperty("ManagedRuleGroups")]
        public ManagedRuleGroup[] ManagedRuleGroups{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "DetectionOnly", this.DetectionOnly);
            this.SetParamSimple(map, prefix + "SemanticAnalysis", this.SemanticAnalysis);
            this.SetParamObj(map, prefix + "AutoUpdate.", this.AutoUpdate);
            this.SetParamArrayObj(map, prefix + "ManagedRuleGroups.", this.ManagedRuleGroups);
        }
    }
}

