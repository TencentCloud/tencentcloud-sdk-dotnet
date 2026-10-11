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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReasoningResult : AbstractModel
    {
        
        /// <summary>
        /// <p>实际使用的推理输出模式：enum 或 string。</p>
        /// </summary>
        [JsonProperty("OutputMode")]
        public string OutputMode{ get; set; }

        /// <summary>
        /// <p>枚举模式下的推理结果值。当 OutputMode=enum 时返回，取值对应请求中配置的 EnumValues。</p>
        /// </summary>
        [JsonProperty("EnumValue")]
        public string EnumValue{ get; set; }

        /// <summary>
        /// <p>文本模式下的推理结果值。当 OutputMode=string 时返回，以文本形式描述推理结论。</p>
        /// </summary>
        [JsonProperty("TextValue")]
        public string TextValue{ get; set; }

        /// <summary>
        /// <p>VLM 原始输出文本（未经过结构化校验）。该字段仅用于调试，生产环境可忽略。</p>
        /// </summary>
        [JsonProperty("RawOutput")]
        public string RawOutput{ get; set; }

        /// <summary>
        /// <p>变量替换后的用户 Prompt 文本。该字段仅用于调试，生产环境可忽略。</p>
        /// </summary>
        [JsonProperty("RenderedPrompt")]
        public string RenderedPrompt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputMode", this.OutputMode);
            this.SetParamSimple(map, prefix + "EnumValue", this.EnumValue);
            this.SetParamSimple(map, prefix + "TextValue", this.TextValue);
            this.SetParamSimple(map, prefix + "RawOutput", this.RawOutput);
            this.SetParamSimple(map, prefix + "RenderedPrompt", this.RenderedPrompt);
        }
    }
}

