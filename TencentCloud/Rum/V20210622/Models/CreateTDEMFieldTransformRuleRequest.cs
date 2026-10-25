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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTDEMFieldTransformRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用 ID（必填）</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>目标字段（必填）：page_url / normalized_page_url / page_title / referrer / resource_url / user_id / target_element / target_text</p>
        /// </summary>
        [JsonProperty("TargetField")]
        public string TargetField{ get; set; }

        /// <summary>
        /// <p>匹配方式（必填）：exact / prefix / contains / regex</p>
        /// </summary>
        [JsonProperty("MatchType")]
        public string MatchType{ get; set; }

        /// <summary>
        /// <p>匹配模式（必填）</p>
        /// </summary>
        [JsonProperty("MatchPattern")]
        public string MatchPattern{ get; set; }

        /// <summary>
        /// <p>替换动作（必填）：replace / regex_replace / mask</p>
        /// </summary>
        [JsonProperty("TransformAction")]
        public string TransformAction{ get; set; }

        /// <summary>
        /// <p>规则名称（可选）</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>替换值（replace / regex_replace 使用）</p>
        /// </summary>
        [JsonProperty("ReplaceValue")]
        public string ReplaceValue{ get; set; }

        /// <summary>
        /// <p>优先级（可选）</p>
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// <p>是否启用，默认 true</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "TargetField", this.TargetField);
            this.SetParamSimple(map, prefix + "MatchType", this.MatchType);
            this.SetParamSimple(map, prefix + "MatchPattern", this.MatchPattern);
            this.SetParamSimple(map, prefix + "TransformAction", this.TransformAction);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ReplaceValue", this.ReplaceValue);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

