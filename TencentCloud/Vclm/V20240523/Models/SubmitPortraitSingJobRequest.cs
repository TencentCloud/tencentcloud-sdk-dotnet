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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitPortraitSingJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 传入音频URL地址，音频要求：
        /// - 音频时长：2秒 - 60秒
        /// - 音频格式：mp3、wav、m4a
        /// </summary>
        [JsonProperty("AudioUrl")]
        public string AudioUrl{ get; set; }

        /// <summary>
        /// 传入图片URL地址，图片要求：
        /// - 图片格式：jpg、jpeg、png、bmp、webp
        /// - 图片分辨率：192～4096
        /// - 图片大小：不超过10M
        /// - 图片宽高比：图片【宽：高】在1:2到2:1范围内
        /// - 图片内容：避免上传无人脸/宠物脸或脸部过小、不完整、不清晰、偏转角度过大的图片。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 传入图片Base64编码，编码后请求体大小不超过10M。
        /// 图片Base64编码与URL地址必传其一，如果都传以ImageBase64为准。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 唱演模式，默认使用人像模式。
        /// Person：人像模式，仅支持上传人像图片，人像生成效果更好，如果图中未检测到有效人脸将被拦截，生成时会将视频短边分辨率放缩至512。
        /// Pet：宠物模式，支持宠物等非人像图片，固定生成512:512分辨率视频。
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AudioUrl", this.AudioUrl);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
        }
    }
}

