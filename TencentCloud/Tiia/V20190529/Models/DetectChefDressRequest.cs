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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectChefDressRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片的 Url 。
        /// ImageUrl和ImageBase64必须提供一个，同时存在时优先使用ImageUrl字段。
        /// 图片限制：
        /// • 图片格式：支持PNG、JPG、JPEG、不支持 GIF 图片。
        /// • 图片大小：对应图片 base64 编码后大小不可超过5M。图片分辨率不超过 3840 x 2160pixel。
        /// 建议：
        /// • 接口响应时间会受到图片下载时间的影响，建议使用更可靠的存储服务，推荐将图片存储在腾讯云COS。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 图片经过base64编码的内容。与ImageUrl同时存在时优先使用ImageUrl字段。
        /// 注意：图片需要base64编码，并且要去掉编码头部。
        /// 支持的图片格式：PNG、JPG、JPEG、暂不支持GIF格式。
        /// 支持的图片大小：所下载图片经Base64编码后不超过5M。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 人体检测模型开关，“true”为开启，“false”为关闭
        /// 默认为开启，开启后可先对图片中的人体进行检测之后再进行属性识别
        /// </summary>
        [JsonProperty("EnableDetect")]
        public bool? EnableDetect{ get; set; }

        /// <summary>
        /// 人体优选开关，“true”为开启，“false”为关闭
        /// 开启后自动对检测质量低的人体进行优选过滤，有助于提高属性识别的准确率。
        /// 默认为开启，仅在人体检测开关开启时可配置，人体检测模型关闭时人体优选也关闭
        /// 人体优选开启时，检测到的人体分辨率不超过1920*1080 pixel
        /// </summary>
        [JsonProperty("EnablePreferred")]
        public bool? EnablePreferred{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "EnableDetect", this.EnableDetect);
            this.SetParamSimple(map, prefix + "EnablePreferred", this.EnablePreferred);
        }
    }
}

