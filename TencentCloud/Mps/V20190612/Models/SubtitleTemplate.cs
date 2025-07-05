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

    public class SubtitleTemplate : AbstractModel
    {
        
        /// <summary>
        /// 要压制到视频中的字幕文件地址。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 指定要压制到视频中的字幕轨道，Path 和 StreamIndex 至少指定一个；如果指定了Path，则优先使用Path。
        /// Streamindex的取值须与源文件中的字幕轨索引一致。例如，源文件中的字幕轨为stream#0:3，则StreamIndex应为3，否则可能导致任务处理失败。
        /// 
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StreamIndex")]
        public long? StreamIndex{ get; set; }

        /// <summary>
        /// 字体类型，支持：
        /// <li>hei.ttf：黑体</li>
        /// <li>song.ttf：宋体</li>
        /// <li>kai.ttf（推荐）或 simkai.ttf：楷体</li>
        /// <li>msyh.ttf：微软雅黑</li>
        /// <li>msyhbd.ttf：微软雅黑加粗</li>
        /// <li>hkjgt.ttf：华康金刚体</li>
        /// <li>dhttx.ttf：典黑体特细</li>
        /// <li>xqgdzt.ttf：喜鹊古字典体</li>
        /// <li>qpcyt.ttf：巧拼超圆体</li>
        /// <li>arial.ttf：仅支持英文</li>
        /// <li>dinalternate.ttf：DIN Alternate Bold</li>
        /// <li>helveticalt.ttf：Helvetica</li>
        /// <li>helveticains.ttf：Helvetica Inserat</li>
        /// <li>trajanpro.ttf：TrajanPro-Bold</li>
        /// <li>korean.ttf：韩语</li>
        /// <li>japanese.ttf：日语</li>
        /// <li>thai.ttf：泰语</li>
        /// 默认：hei.ttf 黑体。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FontType")]
        public string FontType{ get; set; }

        /// <summary>
        /// 字体大小，格式：Npx，N 为数值，不指定则以字幕文件中为准。
        /// 默认源视频高度的5%。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FontSize")]
        public string FontSize{ get; set; }

        /// <summary>
        /// 字体颜色，格式：0xRRGGBB，默认值：0xFFFFFF（白色）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// 文字透明度，取值范围：(0, 1]
        /// <li>0：完全透明</li>
        /// <li>1：完全不透明</li>
        /// 默认值：1。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FontAlpha")]
        public float? FontAlpha{ get; set; }

        /// <summary>
        /// 字幕y轴坐标位置，指定此参数会忽略字幕文件自带坐标；支持像素和百分比格式：
        /// 
        /// - 像素：Npx，N范围：[0,4096]。
        /// - 百分百：N%，N范围：[0,100]；例如10%表示字幕y坐标=10%*源视频高度。
        /// 
        /// 默认值：源视频高度*4%。
        /// 注意：坐标轴原点在源视频中轴线底部，字幕基准点在字幕中轴线底部，参考下图：
        /// ![image](https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png)
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// 字幕背景底板的y轴坐标位置；支持像素和百分比格式：
        /// 
        /// - 像素：Npx，N范围：[0,4096]。
        /// - 百分百：N%，N范围：[0,100]；例如10%表示字幕背景底板y坐标=10%*源视频高度。
        /// 
        /// 不传表示不开启字幕背景底板。
        /// 注意：坐标轴原点位于源视频的中轴线底部，字幕背景底板的基准点在其中轴线底部，参考下图：
        /// ![image](https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png)
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BoardY")]
        public string BoardY{ get; set; }

        /// <summary>
        /// 底板的宽度，单位为像素，取值范围：[0,4096]。
        /// 默认源视频宽像素的90%。
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BoardWidth")]
        public long? BoardWidth{ get; set; }

        /// <summary>
        /// 底板的高度。单位为像素，取值范围：[0,4096]。
        /// 默认为源视频高像素的15%。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BoardHeight")]
        public long? BoardHeight{ get; set; }

        /// <summary>
        /// 底板颜色。格式：0xRRGGBB，
        /// 默认值：0x000000（黑色）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BoardColor")]
        public string BoardColor{ get; set; }

        /// <summary>
        /// 字幕背景板透明度，取值范围：[0, 1]
        /// <li>0：完全透明</li>
        /// <li>1：完全不透明</li>
        /// 默认值：0.8。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BoardAlpha")]
        public float? BoardAlpha{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "StreamIndex", this.StreamIndex);
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
        }
    }
}

