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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoLivenessCompareRequest : AbstractModel
    {
        
        /// <summary>
        /// 用于人脸比对照片的URL地址；图片下载后经Base64编码后的数据大小不超过3M，仅支持jpg、png格式。
        /// 
        /// 图片仅支持腾讯云同region的Cos地址，可保障更高的下载速度和稳定性，可使用CreateUploadUrl生成或自行购买Cos。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 比对图片的32位Md5值。
        /// </summary>
        [JsonProperty("ImageMd5")]
        public string ImageMd5{ get; set; }

        /// <summary>
        /// 用于活体检测的视频Url 地址。视频下载后经Base64编码后不超过 8M，视频下载耗时不超过4S，支持mp4、avi、flv格式。
        /// 
        /// 视频仅支持腾讯云同region的Cos地址，可保障更高的下载速度和稳定性，可使用CreateUploadUrl生成或自行购买Cos。
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// 视频的32位Md5值。
        /// </summary>
        [JsonProperty("VideoMd5")]
        public string VideoMd5{ get; set; }

        /// <summary>
        /// 活体检测类型，取值：LIP/ACTION/SILENT。
        /// LIP为数字模式，ACTION为动作模式，SILENT为静默模式，三种模式选择一种传入。
        /// </summary>
        [JsonProperty("LivenessType")]
        public string LivenessType{ get; set; }

        /// <summary>
        /// 数字模式传参：传数字验证码，需自定义四位数字验证码；
        /// 动作模式传参：传动作顺序，需自定义动作顺序(2,1 or 1,2)；
        /// 静默模式传参：空。
        /// </summary>
        [JsonProperty("ValidateData")]
        public string ValidateData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageMd5", this.ImageMd5);
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "VideoMd5", this.VideoMd5);
            this.SetParamSimple(map, prefix + "LivenessType", this.LivenessType);
            this.SetParamSimple(map, prefix + "ValidateData", this.ValidateData);
        }
    }
}

