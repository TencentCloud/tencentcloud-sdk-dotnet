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

    public class CropEnhanceImageOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>图片/PDF的 Base64 值。要求Base64不超过10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。</p>
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// <p>图片/PDF的 Url 地址。要求图片经Base64编码后不超过10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。图片下载时间不超过 3 秒。图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。非腾讯云存储的 Url 速度和稳定性可能受一定影响。</p>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// <p>需要识别的PDF页面的对应页码，仅支持PDF单页识别，默认值为1。</p>
        /// </summary>
        [JsonProperty("PdfPageNumber")]
        public long? PdfPageNumber{ get; set; }

        /// <summary>
        /// <p>0表示关闭切边<br>1表示开启切边，默认为1</p>
        /// </summary>
        [JsonProperty("Crop")]
        public long? Crop{ get; set; }

        /// <summary>
        /// <p>0表示关闭弯曲矫正<br>1表示开启弯曲矫正，默认为1</p>
        /// </summary>
        [JsonProperty("Deskew")]
        public long? Deskew{ get; set; }

        /// <summary>
        /// <p>0表示返回处理后的图和坐标，默认为0<br>1表示只返回坐标，不返回图片</p>
        /// </summary>
        [JsonProperty("OnlyPosition")]
        public long? OnlyPosition{ get; set; }

        /// <summary>
        /// <p>默认-1</p><ul><li>-1 不处理增强</li><li>1 增亮</li><li>2 增强并锐化</li><li>3 黑白</li><li>4 灰度</li><li>5 去阴影增强</li><li>6 点阵图</li></ul>
        /// </summary>
        [JsonProperty("EnhanceType")]
        public long? EnhanceType{ get; set; }

        /// <summary>
        /// <p>0表示不矫正图像方向，默认为0  1表示矫正图像方向</p>
        /// </summary>
        [JsonProperty("AdjustOrientation")]
        public long? AdjustOrientation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "PdfPageNumber", this.PdfPageNumber);
            this.SetParamSimple(map, prefix + "Crop", this.Crop);
            this.SetParamSimple(map, prefix + "Deskew", this.Deskew);
            this.SetParamSimple(map, prefix + "OnlyPosition", this.OnlyPosition);
            this.SetParamSimple(map, prefix + "EnhanceType", this.EnhanceType);
            this.SetParamSimple(map, prefix + "AdjustOrientation", this.AdjustOrientation);
        }
    }
}

