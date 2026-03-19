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

    public class SubtitleBoardConfig : AbstractModel
    {
        
        /// <summary>
        /// 字幕压制模块背景配置开关，0关闭，1开启，默认0
        /// </summary>
        [JsonProperty("SubtitleBoardConfigSwitch")]
        public long? SubtitleBoardConfigSwitch{ get; set; }

        /// <summary>
        /// 字幕背景底板的x轴坐标位置；支持像素和百分比格式：
        /// 
        /// - 像素：Npx，N范围：[-4096,4096]。
        /// - 百分百：N%，N范围：[-100,100]；例如10%表示字幕背景底板x坐标=10%*源视频宽度。
        /// 
        /// 默认值：0px。
        /// 注意：坐标轴原点位于源视频的中轴线底部，字幕底板的基准点在其中轴线底部，参考下图：
        /// ![image](https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png)
        /// </summary>
        [JsonProperty("BoardX")]
        public long? BoardX{ get; set; }

        /// <summary>
        /// BoardX单位, 0 像素，1百分比，默认为0，像素
        /// </summary>
        [JsonProperty("BoardXUnit")]
        public long? BoardXUnit{ get; set; }

        /// <summary>
        /// 字幕背景底板的y轴坐标位置；支持像素和百分比格式：
        /// 
        /// - 像素：Npx，N范围：[0,4096]。
        /// - 百分百：N%，N范围：[0,100]；例如10%表示字幕背景底板y坐标=10%*源视频高度。
        /// 
        /// 不传表示不开启字幕背景底板。
        /// 注意：坐标轴原点位于源视频的中轴线底部，字幕背景底板的基准点在其中轴线底部，参考下图：
        /// ![image](https://ie-mps-1258344699.cos.ap-nanjing.tencentcos.cn/common/cloud/mps-demo/102_ai_subtitle/subtitle_style.png)
        /// </summary>
        [JsonProperty("BoardY")]
        public long? BoardY{ get; set; }

        /// <summary>
        /// BoardY单位, 0 像素，1百分比，默认为0，像素
        /// </summary>
        [JsonProperty("BoardYUnit")]
        public long? BoardYUnit{ get; set; }

        /// <summary>
        /// 底板的宽度，正整数。
        /// - 代表像素时，取值范围：[0,4096]。
        /// - 代表百分数时，[0, 100]。
        /// 开启底板且不填此值时，默认源视频宽像素的90%。
        /// </summary>
        [JsonProperty("BoardWidth")]
        public long? BoardWidth{ get; set; }

        /// <summary>
        /// 底板的宽度单位，0 像素，1百分比，默认为0，像素
        /// </summary>
        [JsonProperty("BoardWidthUnit")]
        public long? BoardWidthUnit{ get; set; }

        /// <summary>
        /// 底板的高度，正整数。
        /// - 代表像素时，取值范围：[0,4096]。
        /// - 代表百分数时，[0, 100]。
        /// 开启底板且不填此值时，默认为源视频高像素的15%。
        /// </summary>
        [JsonProperty("BoardHeight")]
        public long? BoardHeight{ get; set; }

        /// <summary>
        /// 底板的高度单位，0 像素，1百分比，默认为0，像素
        /// </summary>
        [JsonProperty("BoardHeightUnit")]
        public long? BoardHeightUnit{ get; set; }

        /// <summary>
        /// 底板颜色。格式：0xRRGGBB，
        /// 默认值：0x000000（黑色）。
        /// </summary>
        [JsonProperty("BoardColor")]
        public string BoardColor{ get; set; }

        /// <summary>
        /// 字幕背景板透明度，取值范围：[0, 1]
        /// <li>0：完全透明</li>
        /// <li>1：完全不透明</li>
        /// 默认值：0.8。
        /// </summary>
        [JsonProperty("BoardAlpha")]
        public float? BoardAlpha{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleBoardConfigSwitch", this.SubtitleBoardConfigSwitch);
            this.SetParamSimple(map, prefix + "BoardX", this.BoardX);
            this.SetParamSimple(map, prefix + "BoardXUnit", this.BoardXUnit);
            this.SetParamSimple(map, prefix + "BoardY", this.BoardY);
            this.SetParamSimple(map, prefix + "BoardYUnit", this.BoardYUnit);
            this.SetParamSimple(map, prefix + "BoardWidth", this.BoardWidth);
            this.SetParamSimple(map, prefix + "BoardWidthUnit", this.BoardWidthUnit);
            this.SetParamSimple(map, prefix + "BoardHeight", this.BoardHeight);
            this.SetParamSimple(map, prefix + "BoardHeightUnit", this.BoardHeightUnit);
            this.SetParamSimple(map, prefix + "BoardColor", this.BoardColor);
            this.SetParamSimple(map, prefix + "BoardAlpha", this.BoardAlpha);
        }
    }
}

