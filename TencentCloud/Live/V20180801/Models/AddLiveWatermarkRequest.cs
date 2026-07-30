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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddLiveWatermarkRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>水印图片 URL。<br>URL中禁止包含的字符：<br> ;(){}$&gt;`#&quot;'|</p>
        /// </summary>
        [JsonProperty("PictureUrl")]
        public string PictureUrl{ get; set; }

        /// <summary>
        /// <p>水印名称。<br>最长30字节。</p>
        /// </summary>
        [JsonProperty("WatermarkName")]
        public string WatermarkName{ get; set; }

        /// <summary>
        /// <p>显示位置，X轴偏移，单位是百分比，默认 0。</p>
        /// </summary>
        [JsonProperty("XPosition")]
        public long? XPosition{ get; set; }

        /// <summary>
        /// <p>显示位置，Y轴偏移，单位是百分比，默认 0。</p>
        /// </summary>
        [JsonProperty("YPosition")]
        public long? YPosition{ get; set; }

        /// <summary>
        /// <p>水印宽度，占直播原始画面宽度百分比，建议高宽只设置一项，另外一项会自适应缩放，避免变形。默认原始宽度。</p>
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// <p>水印高度，占直播原始画面高度百分比，建议高宽只设置一项，另外一项会自适应缩放，避免变形。默认原始高度。</p>
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// <p>背景水印宽度。默认宽度1920。</p><p>取值范围：[360, 4096]</p><p>单位：px</p>
        /// </summary>
        [JsonProperty("BackgroundWidth")]
        public long? BackgroundWidth{ get; set; }

        /// <summary>
        /// <p>背景水印高度。默认高度1080。</p><p>取值范围：[360, 4096]</p><p>单位：px</p>
        /// </summary>
        [JsonProperty("BackgroundHeight")]
        public long? BackgroundHeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PictureUrl", this.PictureUrl);
            this.SetParamSimple(map, prefix + "WatermarkName", this.WatermarkName);
            this.SetParamSimple(map, prefix + "XPosition", this.XPosition);
            this.SetParamSimple(map, prefix + "YPosition", this.YPosition);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "BackgroundWidth", this.BackgroundWidth);
            this.SetParamSimple(map, prefix + "BackgroundHeight", this.BackgroundHeight);
        }
    }
}

