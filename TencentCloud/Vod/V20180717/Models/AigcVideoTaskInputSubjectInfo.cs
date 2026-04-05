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

    public class AigcVideoTaskInputSubjectInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>固定主体Id。</p><ul><li>Kling主体<strong>必选</strong>；</li><li>Vidu主体可选。</li></ul>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>固定名称。</p><ul><li>Vidu主体<strong>必选</strong>，可在 prompt 中加入 [@name] 使用。如 name 为小明时，prompt 中描述为 [@小明] 。</li><li>Kling主体可选。</li></ul>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p><strong>仅Vidu有效。</strong>音色ID用来决定视频中的声音音色，为空时系统会自动推荐。</p>
        /// </summary>
        [JsonProperty("VoiceId")]
        public string VoiceId{ get; set; }

        /// <summary>
        /// <p><strong>仅Vidu有效。</strong>临时主体图片，最多3张图片<br>注1：支持传入图片URL（确保可访问）；<br>注2：图片支持 png、jpeg、jpg、webp格式；<br>注3：图片像素不能小于 128*128，且比例需要小于1:4或者4:1。</p>
        /// </summary>
        [JsonProperty("ImageUrls")]
        public string[] ImageUrls{ get; set; }

        /// <summary>
        /// <p><strong>仅Vidu有效。</strong>临时主体视频，最多1个5秒视频注1：仅参考生viduq2-pro模型支持使用视频主体；注2：最多支持上传 1个5秒 的视频；注3：视频支持 mp4、avi、mov格式；注4：视频像素不能小于 128*128，且比例需要小于1:4或者4:1；</p>
        /// </summary>
        [JsonProperty("VideoUrls")]
        public string[] VideoUrls{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "VoiceId", this.VoiceId);
            this.SetParamArraySimple(map, prefix + "ImageUrls.", this.ImageUrls);
            this.SetParamArraySimple(map, prefix + "VideoUrls.", this.VideoUrls);
        }
    }
}

