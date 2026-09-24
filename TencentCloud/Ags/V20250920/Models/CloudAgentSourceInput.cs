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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudAgentSourceInput : AbstractModel
    {
        
        /// <summary>
        /// <p>来源类型。MANUAL：直接提交 Agent Descriptors JSON 文本；URL_IMPORT：从远端 Agent Card / AGUI 端点导入。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Type=MANUAL 时必填；值为通用 JSON object 文本；A2A 标准校验或 AGUI/CUSTOM 规则由后端执行。（JSON 字符串形式）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Descriptors")]
        public string Descriptors{ get; set; }

        /// <summary>
        /// <p>A2A：Agent Card URL；AGUI：Runtime Endpoint URL。Type=URL_IMPORT 时必填，HTTPS。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndpointURL")]
        public string EndpointURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Descriptors", this.Descriptors);
            this.SetParamSimple(map, prefix + "EndpointURL", this.EndpointURL);
        }
    }
}

