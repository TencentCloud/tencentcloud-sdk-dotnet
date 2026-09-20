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

    public class EventPartInfo : AbstractModel
    {
        
        /// <summary>
        /// 文本内容，最大长度 8192 字符。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 是否为思考内容。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Thought")]
        public bool? Thought{ get; set; }

        /// <summary>
        /// 工具调用信息，JSON 字符串，最大长度 8192 字符。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FunctionCall")]
        public string FunctionCall{ get; set; }

        /// <summary>
        /// 工具返回信息，JSON 字符串，最大长度 8192 字符。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FunctionResponse")]
        public string FunctionResponse{ get; set; }

        /// <summary>
        /// 内联数据。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InlineData")]
        public InlineDataInfo InlineData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Thought", this.Thought);
            this.SetParamSimple(map, prefix + "FunctionCall", this.FunctionCall);
            this.SetParamSimple(map, prefix + "FunctionResponse", this.FunctionResponse);
            this.SetParamObj(map, prefix + "InlineData.", this.InlineData);
        }
    }
}

