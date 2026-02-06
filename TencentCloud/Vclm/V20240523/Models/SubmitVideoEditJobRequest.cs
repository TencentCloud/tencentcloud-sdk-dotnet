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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitVideoEditJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 参考视频URL。默认为待编辑视频。
        /// - 视频格式：支持MP4
        /// - 视频时长：输入视频时长≤5秒
        /// - 视频大小：不超过200M
        /// - 视频文件：输入的视频帧率及分辨率不做限制（建议输入16：9或9：16的视频；分辨率建议在2160px内，帧率建议在60fps内）；输出视频是帧率会≥16fps，分辨率为720p
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// 视频内容的描述，中文正向提示词。支持视频内容增加、删除、修改等能力
        /// - 最多支持200个 utf-8 字符（首尾空格不计入字符数）
        /// - 不传prompt的时候，Images.N参考图列表必须要传图，且传的图片是经过图片编辑之后的结果图
        /// </summary>
        [JsonProperty("Prompt")]
        public string Prompt{ get; set; }

        /// <summary>
        /// 参考图列表。用于对视频内容做风格迁移、内容替换、内容删减、内容增加做参考。
        /// - 支持传入图片Base64编码或图片URL
        /// - 图片格式：支持jpg，png，jpeg，webp，bmp，tiff 格式
        /// - 图片文件：大小不能超过10MB（base64后）。单边分辨率不超过5000px，不小于50px，图片长宽限制1:4 ~ 4:1。
        /// 示例值：[{ "Url": "https://console.cloud.tencent.com/cos/image.png"}]
        /// </summary>
        [JsonProperty("Images")]
        public Image[] Images{ get; set; }

        /// <summary>
        /// 图片base64或者图片url
        /// 
        /// - Base64 和 Url 必须提供一个，如果都提供以Url为准。
        /// - 上传图url大小不超过 8M
        /// - 支持jpg，png，jpeg，webp，bmp，tiff 格式
        /// - 单边分辨率不超过5000，不小于50，长宽限制1:4 ~ 4:1
        /// </summary>
        [JsonProperty("Image")]
        [System.Obsolete]
        public Image Image{ get; set; }

        /// <summary>
        /// 扩展字段。
        /// </summary>
        [JsonProperty("VideoEditParam")]
        public VideoEditParam VideoEditParam{ get; set; }

        /// <summary>
        /// 为生成视频添加标识的开关，默认为1。传0 需前往  [控制台](https://console.cloud.tencent.com/vtc/setting)  申请开启显式标识自主完成后方可生效。
        /// 1：添加标识；
        /// 0：不添加标识；
        /// 其他数值：默认按1处理。
        /// 建议您使用显著标识来提示，该视频是 AI 生成的视频。
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// 标识内容设置。
        /// 默认在生成视频的右下角添加“ AI 生成”或“视频由 AI 生成”字样，如需替换为其他的标识图片，需前往   [控制台](https://console.cloud.tencent.com/vtc/setting)  申请开启显式标识自主完成。
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "Prompt", this.Prompt);
            this.SetParamArrayObj(map, prefix + "Images.", this.Images);
            this.SetParamObj(map, prefix + "Image.", this.Image);
            this.SetParamObj(map, prefix + "VideoEditParam.", this.VideoEditParam);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
        }
    }
}

