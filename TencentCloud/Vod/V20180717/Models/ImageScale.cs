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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageScale : AbstractModel
    {
        
        /// <summary>
        /// 图片缩放的操作类型。可选模式有：
        /// <li>WidthFirst : 指定图片的宽为 Width ，高度等比缩放。</li>
        /// <li>HeightFirst : 指定图片的高为 Height ，宽度等比缩放。</li>
        /// <li>LongEdgeFirst : 指定图片的长边为 LongEdge ，短边等比缩放。</li>
        /// <li>ShortEdgeFirst : 指定图片的短边为 ShortEdge ，长边等比缩放。</li>
        /// <li>Force : 忽略原图宽高比例，指定图片宽度为 Width，高度为 Height ，强行缩放图片，可能导致目标图片变形。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 输出图片的高度，单位为像素。当 Type 取值为 HeightFirst 或 Force 时此字段有效。
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// 输出图片的宽度，单位为像素。当 Type 取值为 WidthFirst 或 Force 时此字段有效。
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// 输出图片的长边长度，单位为像素。当 Type 取值为 LongEdgeFirst 时此字段有效。
        /// </summary>
        [JsonProperty("LongEdge")]
        public ulong? LongEdge{ get; set; }

        /// <summary>
        /// 输出图片的短边长度，单位为像素。当 Type 取值为 ShortEdgeFirst 时此字段有效。
        /// </summary>
        [JsonProperty("ShortEdge")]
        public ulong? ShortEdge{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "LongEdge", this.LongEdge);
            this.SetParamSimple(map, prefix + "ShortEdge", this.ShortEdge);
        }
    }
}

