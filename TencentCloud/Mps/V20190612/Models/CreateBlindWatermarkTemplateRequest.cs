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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBlindWatermarkTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 数字水印类型，可选值：<li>blind-basic：基础版权数字水印；</li><li>blind-nagra：NAGRA水印；</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 数字水印文字内容，长度不超过64个字符，NAGRA水印类型的模板创建后不支持修改文字内容。
        /// </summary>
        [JsonProperty("TextContent")]
        public string TextContent{ get; set; }

        /// <summary>
        /// 数字水印模板名称，支持中文、英文、数字、_、-和. 六种格式，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 数字水印模板描述信息，长度限制：256 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 数字水印强度。
        /// default: 默认，高清画质和抗性平衡
        /// stronger:画质清晰，抗性较强
        /// strongest:画质一般，抗性最强
        /// </summary>
        [JsonProperty("Strength")]
        public string Strength{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TextContent", this.TextContent);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Strength", this.Strength);
        }
    }
}

