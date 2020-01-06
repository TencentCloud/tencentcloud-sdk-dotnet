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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateWatermarkTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 水印类型，可选值：
        /// <li>image：图片水印；</li>
        /// <li>text：文字水印；</li>
        /// <li>svg：SVG 水印。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 水印模板名称，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 模板描述信息，长度限制：256 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 原点位置，可选值：
        /// <li>TopLeft：表示坐标原点位于视频图像左上角，水印原点为图片或文字的左上角；</li>
        /// <li>TopRight：表示坐标原点位于视频图像的右上角，水印原点为图片或文字的右上角；</li>
        /// <li>BottomLeft：表示坐标原点位于视频图像的左下角，水印原点为图片或文字的左下角；</li>
        /// <li>BottomRight：表示坐标原点位于视频图像的右下角，水印原点为图片或文字的右下角。</li>
        /// 默认值：TopLeft。
        /// </summary>
        [JsonProperty("CoordinateOrigin")]
        public string CoordinateOrigin{ get; set; }

        /// <summary>
        /// 水印原点距离视频图像坐标原点的水平位置。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示水印 XPos 为视频宽度指定百分比，如 10% 表示 XPos 为视频宽度的 10%；</li>
        /// <li>当字符串以 px 结尾，表示水印 XPos 为指定像素，如 100px 表示 XPos 为 100 像素。</li>
        /// 默认值：0px。
        /// </summary>
        [JsonProperty("XPos")]
        public string XPos{ get; set; }

        /// <summary>
        /// 水印原点距离视频图像坐标原点的垂直位置。支持 %、px 两种格式：
        /// <li>当字符串以 % 结尾，表示水印 YPos 为视频高度指定百分比，如 10% 表示 YPos 为视频高度的 10%；</li>
        /// <li>当字符串以 px 结尾，表示水印 YPos 为指定像素，如 100px 表示 YPos 为 100 像素。</li>
        /// 默认值：0px。
        /// </summary>
        [JsonProperty("YPos")]
        public string YPos{ get; set; }

        /// <summary>
        /// 图片水印模板，仅当 Type 为 image，该字段必填且有效。
        /// </summary>
        [JsonProperty("ImageTemplate")]
        public ImageWatermarkInput ImageTemplate{ get; set; }

        /// <summary>
        /// 文字水印模板，仅当 Type 为 text，该字段必填且有效。
        /// </summary>
        [JsonProperty("TextTemplate")]
        public TextWatermarkTemplateInput TextTemplate{ get; set; }

        /// <summary>
        /// SVG 水印模板，仅当 Type 为 svg，该字段必填且有效。
        /// </summary>
        [JsonProperty("SvgTemplate")]
        public SvgWatermarkInput SvgTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "CoordinateOrigin", this.CoordinateOrigin);
            this.SetParamSimple(map, prefix + "XPos", this.XPos);
            this.SetParamSimple(map, prefix + "YPos", this.YPos);
            this.SetParamObj(map, prefix + "ImageTemplate.", this.ImageTemplate);
            this.SetParamObj(map, prefix + "TextTemplate.", this.TextTemplate);
            this.SetParamObj(map, prefix + "SvgTemplate.", this.SvgTemplate);
        }
    }
}

