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

    public class RecognizeTableMultiOCRRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片/PDF的 Base64 值。 要求图片/PDF经Base64编码后不超过 10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。 图片支持的像素范围：需介于20-10000px之间。 图片的 ImageUrl、ImageBase64 必须提供一个，如果都提供，只使用 ImageUrl。 
        /// </summary>
        [JsonProperty("ImageBase64")]
        public string ImageBase64{ get; set; }

        /// <summary>
        /// 图片/PDF的 Url 地址。 要求图片/PDF经Base64编码后不超过 10M，分辨率建议600*800以上，支持PNG、JPG、JPEG、BMP、PDF格式。 图片支持的像素范围：需介于20-10000px之间。 图片存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议图片存储于腾讯云。非腾讯云存储的 Url 速度和稳定性可能受一定影响。 
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 文档的起始页码。  当传入文件是PDF型时，用来指定识别的起始页码，识别的页码包含当前值。
        /// </summary>
        [JsonProperty("PdfStartPageNumber")]
        public long? PdfStartPageNumber{ get; set; }

        /// <summary>
        /// 文档的结束页码。 当传入文件是PDF类型时，用来指定识别的结束页码，识别的页码包含当前值。单次调用最多支持识别3页内容，即PdfEndPageNumber-PdfStartPageNumber需要不大于3。
        /// </summary>
        [JsonProperty("PdfEndPageNumber")]
        public long? PdfEndPageNumber{ get; set; }

        /// <summary>
        /// 配置选项，支持配置输出数据格式。
        /// 
        /// * **Mdbase64** 返回 base64 编码的 markdown 格式文本。
        /// * **Excelbase64** 返回 base64 编码的 excel 文件。
        /// </summary>
        [JsonProperty("DataFormat")]
        public string DataFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageBase64", this.ImageBase64);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "PdfStartPageNumber", this.PdfStartPageNumber);
            this.SetParamSimple(map, prefix + "PdfEndPageNumber", this.PdfEndPageNumber);
            this.SetParamSimple(map, prefix + "DataFormat", this.DataFormat);
        }
    }
}

