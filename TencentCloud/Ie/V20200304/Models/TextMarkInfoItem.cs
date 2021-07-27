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

    public class TextMarkInfoItem : AbstractModel
    {
        
        /// <summary>
        /// 文字内容。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 文字水印X坐标。
        /// </summary>
        [JsonProperty("PosX")]
        public long? PosX{ get; set; }

        /// <summary>
        /// 文字水印Y坐标。
        /// </summary>
        [JsonProperty("PosY")]
        public long? PosY{ get; set; }

        /// <summary>
        /// 文字大小
        /// </summary>
        [JsonProperty("FontSize")]
        public long? FontSize{ get; set; }

        /// <summary>
        /// 字体，可选项：hei,song，simkai,arial；默认hei(黑体）。
        /// </summary>
        [JsonProperty("FontFile")]
        public string FontFile{ get; set; }

        /// <summary>
        /// 字体颜色，颜色见附录，不填默认black。
        /// </summary>
        [JsonProperty("FontColor")]
        public string FontColor{ get; set; }

        /// <summary>
        /// 文字透明度，可选值0-1。0：不透明，1：全透明。默认为0
        /// </summary>
        [JsonProperty("FontAlpha")]
        public float? FontAlpha{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "PosX", this.PosX);
            this.SetParamSimple(map, prefix + "PosY", this.PosY);
            this.SetParamSimple(map, prefix + "FontSize", this.FontSize);
            this.SetParamSimple(map, prefix + "FontFile", this.FontFile);
            this.SetParamSimple(map, prefix + "FontColor", this.FontColor);
            this.SetParamSimple(map, prefix + "FontAlpha", this.FontAlpha);
        }
    }
}

