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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OCRItem : AbstractModel
    {
        
        /// <summary>
        /// 检测到的文本坐标信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TextPosition")]
        public Coordinate TextPosition{ get; set; }

        /// <summary>
        /// 文本命中恶意违规类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EvilType")]
        public long? EvilType{ get; set; }

        /// <summary>
        /// 检测到的文本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TextContent")]
        public string TextContent{ get; set; }

        /// <summary>
        /// 文本涉嫌违规分值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Rate")]
        public long? Rate{ get; set; }

        /// <summary>
        /// 文本命中具体标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EvilLabel")]
        public string EvilLabel{ get; set; }

        /// <summary>
        /// 文本命中违规的关键词
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TextPosition.", this.TextPosition);
            this.SetParamSimple(map, prefix + "EvilType", this.EvilType);
            this.SetParamSimple(map, prefix + "TextContent", this.TextContent);
            this.SetParamSimple(map, prefix + "Rate", this.Rate);
            this.SetParamSimple(map, prefix + "EvilLabel", this.EvilLabel);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
        }
    }
}

