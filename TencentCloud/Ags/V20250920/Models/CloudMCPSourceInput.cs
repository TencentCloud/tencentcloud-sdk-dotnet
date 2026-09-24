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

    public class CloudMCPSourceInput : AbstractModel
    {
        
        /// <summary>
        /// <p>来源类型。MANUAL：直接提交 MCP Descriptors JSON 文本；URL_IMPORT：从远端 MCP server.json URL 导入。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Type=MANUAL 时必填；值为完整 MCP server.json 对象的 JSON 文本；完整 MCP 2025-12-11 标准校验由后端执行。（JSON 字符串形式）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Descriptors")]
        public string Descriptors{ get; set; }

        /// <summary>
        /// <p>远端 MCP server.json URL；HTTPS。Type=URL_IMPORT 时必填。Version 从远端 initialize.serverInfo.version 观测获得，无需请求参数。</p>
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

