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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChecklistPoint : AbstractModel
    {
        
        /// <summary>
        /// <p>合同风险审查清单检查点名称</p>
        /// </summary>
        [JsonProperty("Summary")]
        public string Summary{ get; set; }

        /// <summary>
        /// <p>合同风险审查清单检查点详细描述，说明具体风险信息</p>
        /// </summary>
        [JsonProperty("Explanation")]
        public string Explanation{ get; set; }

        /// <summary>
        /// <p>合同风险审查清单检查点对应的风险等级，一般分为 高风险、中风险、一般风险</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>合同风险审查清单检查点ID，创建清单时无需填写</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>合同风险审查清单检查点是否不可缺失，若为true，相关条款未出现在内容中，视作风险</p>
        /// </summary>
        [JsonProperty("IsIndispensable")]
        public bool? IsIndispensable{ get; set; }

        /// <summary>
        /// <p>合同风险审查清单检查点是否要求和参考条款一致</p>
        /// </summary>
        [JsonProperty("IsConsistentWithReferenceItem")]
        public bool? IsConsistentWithReferenceItem{ get; set; }

        /// <summary>
        /// <p>合同风险审查清单检查点参考条款，用于辅助审查</p>
        /// </summary>
        [JsonProperty("ReferenceItem")]
        public string ReferenceItem{ get; set; }

        /// <summary>
        /// <p>合同风险审查清单检查点固定修改建议，优先级高于AiSuggestion</p>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// <p>合同风险审查清单检查点AI修改建议提示，会参考该配置生成对应的修改建议</p>
        /// </summary>
        [JsonProperty("AiSuggestion")]
        public string AiSuggestion{ get; set; }

        /// <summary>
        /// <p>合同风险审查清单检查点表现标签，用于自定义不同的风险类型</p>
        /// </summary>
        [JsonProperty("RiskPresentation")]
        public string[] RiskPresentation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Summary", this.Summary);
            this.SetParamSimple(map, prefix + "Explanation", this.Explanation);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "IsIndispensable", this.IsIndispensable);
            this.SetParamSimple(map, prefix + "IsConsistentWithReferenceItem", this.IsConsistentWithReferenceItem);
            this.SetParamSimple(map, prefix + "ReferenceItem", this.ReferenceItem);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "AiSuggestion", this.AiSuggestion);
            this.SetParamArraySimple(map, prefix + "RiskPresentation.", this.RiskPresentation);
        }
    }
}

