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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetWatermarkRequest : AbstractModel
    {
        
        /// <summary>
        /// 低代码互动课堂的SdkAppId。
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 老师视频区域的水印参数地址，设置为空字符串表示删除
        /// </summary>
        [JsonProperty("TeacherUrl")]
        public string TeacherUrl{ get; set; }

        /// <summary>
        /// 白板视频区域的水印参数地址，设置为空字符串表示删除
        /// </summary>
        [JsonProperty("BoardUrl")]
        public string BoardUrl{ get; set; }

        /// <summary>
        /// 视频默认图片（在没有视频流的时候显示），设置为空字符串表示删除
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// 白板区域水印的宽度，取值:0-100，默认为0，表示区域X方向的百分比
        /// </summary>
        [JsonProperty("BoardW")]
        public float? BoardW{ get; set; }

        /// <summary>
        /// 白板区域水印的高度，取值:0-100，默认为0, 表示区域Y方向的百分比
        /// </summary>
        [JsonProperty("BoardH")]
        public float? BoardH{ get; set; }

        /// <summary>
        /// 白板区域水印X偏移, 取值:0-100, 表示区域X方向的百分比。比如50，则表示位于X轴中间
        /// </summary>
        [JsonProperty("BoardX")]
        public float? BoardX{ get; set; }

        /// <summary>
        /// 白板区域水印Y偏移, 取值:0-100, 表示区域X方向的百分比。比如50，则表示位于X轴中间
        /// </summary>
        [JsonProperty("BoardY")]
        public float? BoardY{ get; set; }

        /// <summary>
        /// 老师视频区域水印的宽度，取值:0-100，默认为0，表示区域X方向的百分比
        /// </summary>
        [JsonProperty("TeacherW")]
        public float? TeacherW{ get; set; }

        /// <summary>
        /// 老师视频区域水印的高度，取值:0-100，默认为0, 表示区域Y方向的百分比
        /// </summary>
        [JsonProperty("TeacherH")]
        public float? TeacherH{ get; set; }

        /// <summary>
        /// 老师视频区域水印X偏移, 取值:0-100, 表示区域X方向的百分比。比如50，则表示位于X轴中间
        /// </summary>
        [JsonProperty("TeacherX")]
        public float? TeacherX{ get; set; }

        /// <summary>
        /// 老师视频区域水印Y偏移, 取值:0-100, 表示区域X方向的百分比。比如50，则表示位于X轴中间
        /// </summary>
        [JsonProperty("TeacherY")]
        public float? TeacherY{ get; set; }

        /// <summary>
        /// 文字水印内容，设置为空字符串表示删除
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 文字水印颜色
        /// </summary>
        [JsonProperty("TextColor")]
        public string TextColor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "TeacherUrl", this.TeacherUrl);
            this.SetParamSimple(map, prefix + "BoardUrl", this.BoardUrl);
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "BoardW", this.BoardW);
            this.SetParamSimple(map, prefix + "BoardH", this.BoardH);
            this.SetParamSimple(map, prefix + "BoardX", this.BoardX);
            this.SetParamSimple(map, prefix + "BoardY", this.BoardY);
            this.SetParamSimple(map, prefix + "TeacherW", this.TeacherW);
            this.SetParamSimple(map, prefix + "TeacherH", this.TeacherH);
            this.SetParamSimple(map, prefix + "TeacherX", this.TeacherX);
            this.SetParamSimple(map, prefix + "TeacherY", this.TeacherY);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "TextColor", this.TextColor);
        }
    }
}

