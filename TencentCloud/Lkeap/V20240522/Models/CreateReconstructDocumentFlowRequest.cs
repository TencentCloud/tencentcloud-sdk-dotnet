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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateReconstructDocumentFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件类型。
        /// 
        /// **支持的文件类型：**
        /// - `PDF`、`DOC`、`DOCX`、`XLS`、`XLSX`、`PPT`、`PPTX`、`MD`、`TXT`、`PNG`、`JPG`、`JPEG`、`CSV`、`HTML`、`EPUB`、`BMP`、`GIF`、`WEBP`、`HEIC`、`EPS`、`ICNS`、`IM`、`PCX`、`PPM`、`TIFF`、`XBM`、`HEIF`、`JP2`
        /// 
        /// **支持的文件大小：**
        ///  - `PDF` 最大300M
        ///  - `DOCX`、`DOC`、`PPT`、`PPTX` 最大 200M
        ///  - `TXT`、`MD` 最大10M
        ///  - 其他 最大20M
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 说明：文件的 URL 地址。
        /// 备注：文件存储于腾讯云的 URL 可保障更高的下载速度和稳定性，建议文件存储于腾讯云。 非腾讯云存储的 URL 速度和稳定性可能受一定影响。
        /// 参考：[腾讯云COS文档](https://cloud.tencent.com/document/product/436/7749)
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// 文件的 Base64 值。
        /// 支持的文件类型： PNG、JPG、JPEG、PDF、GIF、BMP、TIFF
        /// 支持的文件大小：所下载文件经Base64编码后不超过 8M。文件下载时间不超过 3 秒。
        /// 支持的图片像素：单边介于20-10000px之间。
        /// 文件的 FileUrl、FileBase64 必须提供一个，如果都提供，只使用 FileUrl。
        /// </summary>
        [JsonProperty("FileBase64")]
        public string FileBase64{ get; set; }

        /// <summary>
        /// 说明：文档的起始页码。
        /// 备注：当传入文件是PDF、PDF、PPT、PPTX、DOC类型时，用来指定识别的起始页码，识别的页码包含当前值。
        /// 默认值：无
        /// </summary>
        [JsonProperty("FileStartPageNumber")]
        public long? FileStartPageNumber{ get; set; }

        /// <summary>
        /// 说明：文档的结束页码。
        /// 备注：当传入文件是PDF、PDF、PPT、PPTX、DOC类型时，用来指定识别的结束页码，识别的页码包含当前值。
        /// 默认值：无
        /// </summary>
        [JsonProperty("FileEndPageNumber")]
        public long? FileEndPageNumber{ get; set; }

        /// <summary>
        /// 说明：创建文档解析任务配置信息。
        /// 备注：可设置结果的返回格式
        /// 默认值：无
        /// </summary>
        [JsonProperty("Config")]
        public CreateReconstructDocumentFlowConfig Config{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "FileBase64", this.FileBase64);
            this.SetParamSimple(map, prefix + "FileStartPageNumber", this.FileStartPageNumber);
            this.SetParamSimple(map, prefix + "FileEndPageNumber", this.FileEndPageNumber);
            this.SetParamObj(map, prefix + "Config.", this.Config);
        }
    }
}

