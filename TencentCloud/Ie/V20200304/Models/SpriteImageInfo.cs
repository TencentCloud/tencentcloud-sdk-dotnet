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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpriteImageInfo : AbstractModel
    {
        
        /// <summary>
        /// 表示雪碧图行数，默认：10。
        /// </summary>
        [JsonProperty("RowCount")]
        public ulong? RowCount{ get; set; }

        /// <summary>
        /// 表示雪碧图列数，默认：10。
        /// </summary>
        [JsonProperty("ColumnCount")]
        public ulong? ColumnCount{ get; set; }

        /// <summary>
        /// 第一行元素与顶部像素距离，默认：0。
        /// </summary>
        [JsonProperty("MarginTop")]
        public long? MarginTop{ get; set; }

        /// <summary>
        /// 最后一行元素与底部像素距离，默认：0。
        /// </summary>
        [JsonProperty("MarginBottom")]
        public long? MarginBottom{ get; set; }

        /// <summary>
        /// 最左一行元素与左边像素距离，默认：0。
        /// </summary>
        [JsonProperty("MarginLeft")]
        public long? MarginLeft{ get; set; }

        /// <summary>
        /// 最右一行元素与右边像素距离，默认：0。
        /// </summary>
        [JsonProperty("MarginRight")]
        public long? MarginRight{ get; set; }

        /// <summary>
        /// 小图与元素顶部像素距离，默认：0。
        /// </summary>
        [JsonProperty("PaddingTop")]
        public long? PaddingTop{ get; set; }

        /// <summary>
        /// 小图与元素底部像素距离，默认：0。
        /// </summary>
        [JsonProperty("PaddingBottom")]
        public long? PaddingBottom{ get; set; }

        /// <summary>
        /// 小图与元素左边像素距离，默认：0。
        /// </summary>
        [JsonProperty("PaddingLeft")]
        public long? PaddingLeft{ get; set; }

        /// <summary>
        /// 小图与元素右边像素距离，默认：0。
        /// </summary>
        [JsonProperty("PaddingRight")]
        public long? PaddingRight{ get; set; }

        /// <summary>
        /// 背景颜色，格式：#RRGGBB，默认：#FFFFFF。
        /// </summary>
        [JsonProperty("BackgroundColor")]
        public string BackgroundColor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RowCount", this.RowCount);
            this.SetParamSimple(map, prefix + "ColumnCount", this.ColumnCount);
            this.SetParamSimple(map, prefix + "MarginTop", this.MarginTop);
            this.SetParamSimple(map, prefix + "MarginBottom", this.MarginBottom);
            this.SetParamSimple(map, prefix + "MarginLeft", this.MarginLeft);
            this.SetParamSimple(map, prefix + "MarginRight", this.MarginRight);
            this.SetParamSimple(map, prefix + "PaddingTop", this.PaddingTop);
            this.SetParamSimple(map, prefix + "PaddingBottom", this.PaddingBottom);
            this.SetParamSimple(map, prefix + "PaddingLeft", this.PaddingLeft);
            this.SetParamSimple(map, prefix + "PaddingRight", this.PaddingRight);
            this.SetParamSimple(map, prefix + "BackgroundColor", this.BackgroundColor);
        }
    }
}

