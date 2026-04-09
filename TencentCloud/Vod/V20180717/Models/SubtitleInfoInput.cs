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

    public class SubtitleInfoInput : AbstractModel
    {
        
        /// <summary>
        /// <p>字幕 ID。</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>字体类型。</p><p>枚举值：</p><ul><li>hei.ttf： 黑体</li><li>song.ttf： 宋体</li><li>kai.ttf（推荐）或 simkai.ttf： 楷体</li><li>msyh.ttf： 微软雅黑</li><li>msyhbd.ttf： 微软雅黑加粗</li><li>hkjgt.ttf： 华康金刚体</li><li>dhttx.ttf： 典黑体特细</li><li>xqgdzt.ttf： 喜鹊古字典体</li><li>qpcyt.ttf： 巧拼超圆体</li><li>arial.ttf： 仅支持英文</li><li>dinalternate.ttf： DIN Alternate Bold</li><li>helveticalt.ttf： Helvetica</li><li>helveticains.ttf： Helvetica Inserat</li><li>trajanpro.ttf： TrajanPro-Bold</li><li>korean.ttf： 韩语</li><li>japanese.ttf： 日语</li><li>thai.ttf： 泰语</li><li>roboto.ttf： Roboto</li><li>notosans.ttf： NotoSans</li><li>notosansthai.ttf： 泰语NotoSansThai</li><li>sarabun.ttf： 泰语Sarabun</li><li>kanit.ttf： 泰语Kanit</li><li>charmonman.ttf： 泰语Charmonman</li><li>notonaskharabic.ttf： 阿拉伯语NotoNaskhArabic</li><li>notosansdevanagari.ttf： 印度语NotoSansDevanagari</li><li>notosanstc.ttf： 粤语思源黑体NotoSansTC</li><li>notosanskr.ttf： 韩语NotoSansKR</li><li>gothica1.ttf： 韩语GothicA1</li><li>nanummyeongjo.ttf： 韩语NanumMyeongjo</li><li>notosansjp.ttf： 日语NotoSansJP</li><li>notoserifjp.ttf： 日语NotoSerifJP</li><li>shipporimincho.ttf： 日语ShipporiMincho</li></ul><p>默认值：hei.ttf 黑体</p>
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// <p>字体大小，不指定则以字幕文件中为准。支持像素和百分比格式：</p><ul><li>像素：Npx，N范围：(0,4096]。</li><li>百分比：N%，N范围：(0,100]；例如，10%表示字幕字体大小=10%*源视频高度。不填且字幕文件中无设置时，默认源视频高度的5%。</li></ul>
        /// </summary>
        [JsonProperty("FontSize")]
        public string FontSize{ get; set; }

        /// <summary>
        /// <p>字体颜色，格式：0xRRGGBB。</p><p>默认值：0xFFFFFF（白色）。</p>
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// <p>文字透明度。取值范围：(0, 1]。</p><ul><li>0：完全透明；</li><li>1：完全不透明</li></ul><p>默认值：1</p>
        /// </summary>
        [JsonProperty("FontAlpha")]
        public float? FontAlpha{ get; set; }

        /// <summary>
        /// <p>字幕y轴坐标位置，指定此参数会忽略字幕文件自带坐标；支持像素和百分比格式：</p><ul><li>像素：Npx，N范围：[0,4096]。</li><li>百分比：N%，N范围：[0,100]；例如10%表示字幕y坐标=10%<em>源视频高度。默认值：源视频高度</em>4%。<br>注意：坐标轴原点在源视频中轴线底部，字幕基准点在字幕中轴线底部，参考下图：<img src="https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png" alt="image"></li></ul>
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// <p>字幕背景底板的y轴坐标位置；支持像素和百分比格式：</p><ul><li>像素：Npx，N范围：[0,4096]。</li><li>百分比：N%，N范围：[0,100]；例如10%表示字幕背景底板y坐标=10%*源视频高度。不传表示不开启字幕背景底板。<br>注意：坐标轴原点位于源视频的中轴线底部，字幕背景底板的基准点在其中轴线底部，参考下图：<img src="https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png" alt="image"></li></ul>
        /// </summary>
        [JsonProperty("BoardY")]
        public string BoardY{ get; set; }

        /// <summary>
        /// <p>底板的宽度，正整数。</p><ul><li>像素：Npx，N 取值范围：[0,4096]。</li><li>百分比：N%，N 取值范围：[0, 100]。开启底板且不填此值时，默认源视频宽像素的90%。</li></ul>
        /// </summary>
        [JsonProperty("BoardWidth")]
        public string BoardWidth{ get; set; }

        /// <summary>
        /// <p>底板的高度，正整数。</p><ul><li>像素：Npx，N 取值范围：[0,4096]。</li><li>百分比：N%，N 取值范围：[0, 100]。开启底板且不填此值时，默认为源视频高像素的15%。</li></ul>
        /// </summary>
        [JsonProperty("BoardHeight")]
        public string BoardHeight{ get; set; }

        /// <summary>
        /// <p>底板颜色。格式：0xRRGGBB。</p><p>默认值：0x000000（黑色）。</p>
        /// </summary>
        [JsonProperty("BoardColor")]
        public string BoardColor{ get; set; }

        /// <summary>
        /// <p>字幕背景板透明度，取值范围：[0, 1]。</p><ul><li>0：完全透明；</li><li>1：完全不透明。</li></ul><p>默认值：0.8。</p>
        /// </summary>
        [JsonProperty("BoardAlpha")]
        public float? BoardAlpha{ get; set; }

        /// <summary>
        /// <p>对齐方式。</p><p>枚举值：</p><ul><li>top： 顶部对齐，字幕顶部按位置固定，底部随行数变化。 </li><li>bottom： 底部对齐，字幕底部按位置固定，顶部随行数变化。 </li></ul><p>默认值：bottom</p>
        /// </summary>
        [JsonProperty("Alignment")]
        public string Alignment{ get; set; }

        /// <summary>
        /// <p>描边宽度。浮点数。</p><ul><li>像素：Npx，N 取值范围： [0, 1000]。</li><li>百分比：N%，N 取值范围：[0, 100]。</li></ul><p>不填默认源视频高度的0.3%。</p>
        /// </summary>
        [JsonProperty("OutlineWidth")]
        public string OutlineWidth{ get; set; }

        /// <summary>
        /// <p>描边颜色。格式：0xRRGGBB。</p><p>默认值：0x000000（黑色）。</p>
        /// </summary>
        [JsonProperty("OutlineColor")]
        public string OutlineColor{ get; set; }

        /// <summary>
        /// <p>描边透明度。(0，1] 正浮点数。</p><ul><li>0：完全透明；</li><li>1：完全不透明。</li></ul><p>默认值：1</p>
        /// </summary>
        [JsonProperty("OutlineAlpha")]
        public float? OutlineAlpha{ get; set; }

        /// <summary>
        /// <p>阴影宽度。浮点数。</p><ul><li>像素：Npx，N 取值范围： [0, 1000]。</li><li>百分比：N%，N 取值范围：[0, 100]。不填默认无阴影。</li></ul>
        /// </summary>
        [JsonProperty("ShadowWidth")]
        public string ShadowWidth{ get; set; }

        /// <summary>
        /// <p>阴影颜色。格式：0xRRGGBB。</p><p>默认值：0x000000（黑色），有设置阴影的情况下。</p>
        /// </summary>
        [JsonProperty("ShadowColor")]
        public string ShadowColor{ get; set; }

        /// <summary>
        /// <p>阴影透明度。(0，1] 正浮点数。</p><ul><li>0：完全透明；</li><li>1：完全不透明。</li></ul><p>默认值：1，完全不透明，有设置阴影的情况下。</p>
        /// </summary>
        [JsonProperty("ShadowAlpha")]
        public float? ShadowAlpha{ get; set; }

        /// <summary>
        /// <p>行间距。正整数。</p><ul><li>像素：Npx，N 取值范围： [0, 1000]。</li><li>百分比：N%，N 取值范围：[0, 100]。</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("LineSpacing")]
        public string LineSpacing{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "FontType", this.FontType);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "FontAlpha", this.FontAlpha);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamSimple(map, prefix + "BoardY", this.BoardY);
            this.SetParamSimple(map, prefix + "BoardWidth", this.BoardWidth);
            this.SetParamSimple(map, prefix + "BoardHeight", this.BoardHeight);
            this.SetParamSimple(map, prefix + "BoardColor", this.BoardColor);
            this.SetParamSimple(map, prefix + "BoardAlpha", this.BoardAlpha);
            this.SetParamSimple(map, prefix + "Alignment", this.Alignment);
            this.SetParamSimple(map, prefix + "OutlineWidth", this.OutlineWidth);
            this.SetParamSimple(map, prefix + "OutlineColor", this.OutlineColor);
            this.SetParamSimple(map, prefix + "OutlineAlpha", this.OutlineAlpha);
            this.SetParamSimple(map, prefix + "ShadowWidth", this.ShadowWidth);
            this.SetParamSimple(map, prefix + "ShadowColor", this.ShadowColor);
            this.SetParamSimple(map, prefix + "ShadowAlpha", this.ShadowAlpha);
            this.SetParamSimple(map, prefix + "LineSpacing", this.LineSpacing);
        }
    }
}

