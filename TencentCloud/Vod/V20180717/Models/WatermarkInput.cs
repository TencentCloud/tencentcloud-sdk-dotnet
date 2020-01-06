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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WatermarkInput : AbstractModel
    {
        
        /// <summary>
        /// 水印模板 ID。
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// 文字内容，长度不超过100个字符。仅当水印类型为文字水印时填写。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TextContent")]
        public string TextContent{ get; set; }

        /// <summary>
        /// SVG 内容。长度不超过 2000000 个字符。仅当水印类型为 SVG 水印时填写。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SvgContent")]
        public string SvgContent{ get; set; }

        /// <summary>
        /// 水印的起始时间偏移，单位：秒。不填或填0，表示水印从画面出现时开始显现。
        /// <li>不填或填0，表示水印从画面开始就出现；</li>
        /// <li>当数值大于0时（假设为 n），表示水印从画面开始的第 n 秒出现；</li>
        /// <li>当数值小于0时（假设为 -n），表示水印从离画面结束 n 秒前开始出现。</li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// 水印的结束时间偏移，单位：秒。
        /// <li>不填或填0，表示水印持续到画面结束；</li>
        /// <li>当数值大于0时（假设为 n），表示水印持续到第 n 秒时消失；</li>
        /// <li>当数值小于0时（假设为 -n），表示水印持续到离画面结束 n 秒前消失。</li>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "TextContent", this.TextContent);
            this.SetParamSimple(map, prefix + "SvgContent", this.SvgContent);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
        }
    }
}

