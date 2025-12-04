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

    public class SubmitVideoFaceFusionJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 视频素材下载地址。用户自定义模版视频下载地址，使用前需要先调用视频审核接口进行内容审核。视频限制：分辨率≤4k，fps≤25，视频大小≤1G，时长≤20 秒，支持格式mp4。
        /// 
        /// 输入视频建议：
        /// 姿态：人脸相对镜头水平方向角度转动不超过 90°,垂直方向角度转动不超过 20°。遮挡：脸部遮挡面积不超过 50%，不要完全遮挡五官，不要有半透明遮挡（强光，玻璃，透明眼镜等）、以及细碎离散的脸部遮挡（如飘落的花瓣）。妆容及光照：避免浓妆、复杂妆容，避免复杂光照、闪烁，这些属性无法完全恢复，并对稳定性有影响。针对特殊表情和微表情，针对局部肌肉控制下的微表情，以及过于夸张的特殊表情等不保证表情效果完全恢复。
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// 视频素材模板的人脸位置信息。
        /// 目前最多支持融合视频素材中的 6 张人脸  
        /// 输入图片要求：  
        /// 1、用户图限制大小不超过 10MB  
        /// 2、图片最大分辨率不超过 4k，建议最小为 128，  人脸框最小为 68
        /// 3、支持格式 jpg，png  
        /// 4、如果用户图中未指定人脸且有多张人脸，  默认融合最大人脸  
        /// 输入图片建议：  包含上述视频中出现的人物的单人照，并且正面、清晰、无遮挡
        /// </summary>
        [JsonProperty("TemplateInfos")]
        public FaceTemplateInfo[] TemplateInfos{ get; set; }

        /// <summary>
        /// 用户人脸图片位置信息。
        /// 输入图片要求：
        /// 1、用户图限制大小不超过 10MB
        /// 2、图片最大分辨率不超过 4k，建议最小为 128，人脸框最小为 68
        /// 3、支持格式 jpg，png
        /// 4、如果未指定人脸且用户图中有多张人脸，
        /// 默认融合最大人脸
        /// 输入图建议：
        /// 正脸无遮挡
        /// </summary>
        [JsonProperty("MergeInfos")]
        public FaceMergeInfo[] MergeInfos{ get; set; }

        /// <summary>
        /// 为生成视频添加标识的开关，默认为1。 
        /// 1：添加标识。 0：不添加标识。 其他数值：默认按1处理。 
        /// 建议您使用显著标识来提示，该视频是 AI 生成的视频。
        /// </summary>
        [JsonProperty("LogoAdd")]
        public long? LogoAdd{ get; set; }

        /// <summary>
        /// 视频水印Logo参数标识内容设置。   
        /// 默认在融合结果图右下角添加“AI生成”类似字样，您可根据自身需要替换为其他的Logo图片。   
        /// 输入建议：输入水印图片宽高需小于视频宽高
        /// </summary>
        [JsonProperty("LogoParam")]
        public LogoParam LogoParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamArrayObj(map, prefix + "TemplateInfos.", this.TemplateInfos);
            this.SetParamArrayObj(map, prefix + "MergeInfos.", this.MergeInfos);
            this.SetParamSimple(map, prefix + "LogoAdd", this.LogoAdd);
            this.SetParamObj(map, prefix + "LogoParam.", this.LogoParam);
        }
    }
}

