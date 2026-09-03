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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitQuestionSplitJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>批量ImageUrl图片入口。要求Base64不超过10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。</p><p>入参限制：要求pdf只能有一个url或base64</p>
        /// </summary>
        [JsonProperty("ImageUrlList")]
        public string[] ImageUrlList{ get; set; }

        /// <summary>
        /// <p>批量base64图片入口。要求图片经Base64编码后不超过10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。图片下载时间不超过 3 秒。图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。非腾讯云存储的 Url 速度和稳定性可能受一定影响。</p><p>入参限制：要求pdf只能有一个url或base64</p>
        /// </summary>
        [JsonProperty("ImageBase64List")]
        public string[] ImageBase64List{ get; set; }

        /// <summary>
        /// <p>选择切题模型</p><p>枚举值：</p><ul><li>youtu_crop： 轻量化切题模型，运算速度更快，适合常规切题</li><li>youtu_crop_pro： 属于切题精调大模型，针对双栏、跨栏等复杂版式识别精度大幅提升，但推理耗时更长</li></ul><p>默认值：youtu_crop</p>
        /// </summary>
        [JsonProperty("ModelType")]
        public string ModelType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ImageUrlList.", this.ImageUrlList);
            this.SetParamArraySimple(map, prefix + "ImageBase64List.", this.ImageBase64List);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
        }
    }
}

