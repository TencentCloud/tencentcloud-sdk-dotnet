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

    public class ComposeSubtitleStyle : AbstractModel
    {
        
        /// <summary>
        /// 字幕高度。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示为画布高度的百分比大小，如 10% 表示为画布高度的 10%。</li>
        /// <li>当字符串以 px 结尾，表示单位为像素，如 100px 表示为100像素。</li>
        /// 默认为 FontSize 大小。
        /// </summary>
        [JsonProperty("Height")]
        public string Height{ get; set; }

        /// <summary>
        /// 字幕距离下边框距离，支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示为画布高度的百分比大小，如 10% 表示为画布高度的 10%。</li>
        /// <li>当字符串以 px 结尾，表示单位为像素，如 100px 表示为100像素。</li>
        /// 默认：0px
        /// </summary>
        [JsonProperty("MarginBottom")]
        public string MarginBottom{ get; set; }

        /// <summary>
        /// 字体类型，支持：
        /// <li>SimHei：黑体（默认）。</li>
        /// <li>SimSun：宋体。</li>
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// 字体大小，支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示为画布高度的百分比大小，如 10% 表示为画布高度的 10%。</li>
        /// <li>当字符串以 px 结尾，表示单位为像素，如 100px 表示为100像素。</li>
        /// 默认：2%
        /// </summary>
        [JsonProperty("FontSize")]
        public string FontSize{ get; set; }

        /// <summary>
        /// 是否使用粗体，和字体相关，可选值：
        /// <li>0：否（默认）。</li>
        /// <li>1：是。</li>
        /// </summary>
        [JsonProperty("FontBold")]
        public long? FontBold{ get; set; }

        /// <summary>
        /// 是否使用斜体，和字体相关，可选值：
        /// <li>0：否（默认）。</li>
        /// <li>1：是。</li>
        /// </summary>
        [JsonProperty("FontItalic")]
        public long? FontItalic{ get; set; }

        /// <summary>
        /// 字体颜色，格式：#RRGGBBAA。  
        /// 默认值：0x000000FF（黑色）。  
        /// 注意：其中 AA 部分指的是透明度，为可选。
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// 文字对齐方式：
        /// <li>Center：居中（默认）。</li>
        /// <li>Left：左对齐。</li>
        /// <li>Right：右对齐。</li>
        /// </summary>
        [JsonProperty("FontAlign")]
        public string FontAlign{ get; set; }

        /// <summary>
        /// 用于字幕对齐留白：
        /// <li>FontAlign=Left 时，表示距离左边距离。</li>
        /// <li>FontAlign=Right时，表示距离右边距离。</li>
        /// 支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示为画布宽度的百分比大小，如 10% 表示为画布宽度的 10%。</li>
        /// <li>当字符串以 px 结尾，表示单位为像素，如 100px 表示为100像素。</li>
        /// </summary>
        [JsonProperty("FontAlignMargin")]
        public string FontAlignMargin{ get; set; }

        /// <summary>
        /// 字体边框宽度，支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示为画布高度的百分比大小，如 10% 表示为画布高度的 10%。</li>
        /// <li>当字符串以 px 结尾，表示单位为像素，如 100px 表示为100像素。</li>
        /// 默认： 0，表示不需要边框。
        /// </summary>
        [JsonProperty("BorderWidth")]
        public string BorderWidth{ get; set; }

        /// <summary>
        /// 边框颜色，当 BorderWidth 不为 0 时生效，其值格式和 FontColor 一致。
        /// </summary>
        [JsonProperty("BorderColor")]
        public string BorderColor{ get; set; }

        /// <summary>
        /// 文字底色，其值格式和 FontColor 一致。  
        /// 默认为空， 表示不使用底色。
        /// </summary>
        [JsonProperty("BottomColor")]
        public string BottomColor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "MarginBottom", this.MarginBottom);
            this.SetParamSimple(map, prefix + "FontType", this.FontType);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "FontBold", this.FontBold);
            this.SetParamSimple(map, prefix + "FontItalic", this.FontItalic);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "FontAlign", this.FontAlign);
            this.SetParamSimple(map, prefix + "FontAlignMargin", this.FontAlignMargin);
            this.SetParamSimple(map, prefix + "BorderWidth", this.BorderWidth);
            this.SetParamSimple(map, prefix + "BorderColor", this.BorderColor);
            this.SetParamSimple(map, prefix + "BottomColor", this.BottomColor);
        }
    }
}

