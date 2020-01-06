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

namespace TencentCloud.Ticm.V20181127.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageModerationRequest : AbstractModel
    {
        
        /// <summary>
        /// 本次调用支持的识别场景，可选值如下：
        /// 1. PORN，即色情识别
        /// 2. TERRORISM，即暴恐识别
        /// 3. POLITICS，即政治敏感识别
        /// 
        /// 支持多场景（Scenes）一起检测。例如，使用 Scenes=["PORN", "TERRORISM"]，即对一张图片同时进行色情识别和暴恐识别。
        /// </summary>
        [JsonProperty("Scenes")]
        public string[] Scenes{ get; set; }

        /// <summary>
        /// 图片URL地址。 
        /// 图片限制： 
        ///  • 图片格式：PNG、JPG、JPEG。 
        ///  • 图片大小：所下载图片经Base64编码后不超过4M。图片下载时间不超过3秒。 
        ///  • 图片像素：大于50*50像素，否则影响识别效果； 
        ///  • 长宽比：长边：短边<5； 
        /// 接口响应时间会受到图片下载时间的影响，建议使用更可靠的存储服务，推荐将图片存储在腾讯云COS。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 预留字段，后期用于展示更多识别信息。
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// 透传字段，透传简单信息。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 图片经过base64编码的内容。最大不超过4M。与ImageUrl同时存在时优先使用ImageUrl字段。
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Scenes.", this.Scenes);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
        }
    }
}

