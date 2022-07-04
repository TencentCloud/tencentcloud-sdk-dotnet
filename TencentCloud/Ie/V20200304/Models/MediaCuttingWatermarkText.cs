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

namespace TencentCloud.Ie.V20200304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaCuttingWatermarkText : AbstractModel
    {
        
        /// <summary>
        /// 水印文字。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 文字大小
        /// </summary>
        [JsonProperty("FontSize")]
        public ulong? FontSize{ get; set; }

        /// <summary>
        /// 水印水平坐标，单位像素，默认：0。
        /// </summary>
        [JsonProperty("PosX")]
        public ulong? PosX{ get; set; }

        /// <summary>
        /// 水印垂直坐标，单位像素，默认：0。
        /// </summary>
        [JsonProperty("PosY")]
        public ulong? PosY{ get; set; }

        /// <summary>
        /// 文字颜色，格式为：#RRGGBBAA，默认值：#000000。
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// 文字透明度，范围：0~100，默认值：100。
        /// </summary>
        [JsonProperty("FontAlpha")]
        public ulong? FontAlpha{ get; set; }

        /// <summary>
        /// 指定坐标原点，可选值：
        /// <li>LeftTop：PosXY 表示水印左上点到图片左上点的相对位置</li>
        /// <li>RightTop：PosXY 表示水印右上点到图片右上点的相对位置</li>
        /// <li>LeftBottom：PosXY 表示水印左下点到图片左下点的相对位置</li>
        /// <li>RightBottom：PosXY 表示水印右下点到图片右下点的相对位置</li>
        /// <li>Center：PosXY 表示水印中心点到图片中心点的相对位置</li>
        /// 默认：LeftTop。
        /// </summary>
        [JsonProperty("PosOriginType")]
        public string PosOriginType{ get; set; }

        /// <summary>
        /// 字体，可选值：
        /// <li>SimHei</li>
        /// <li>SimKai</li>
        /// <li>Arial</li>
        /// 默认 SimHei。
        /// </summary>
        [JsonProperty("Font")]
        public string Font{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "PosX", this.PosX);
            this.SetParamSimple(map, prefix + "PosY", this.PosY);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "FontAlpha", this.FontAlpha);
            this.SetParamSimple(map, prefix + "PosOriginType", this.PosOriginType);
            this.SetParamSimple(map, prefix + "Font", this.Font);
        }
    }
}

