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

namespace TencentCloud.Es.V20250101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParseDocument : AbstractModel
    {
        
        /// <summary>
        /// 支持的文件类型：PDF、DOC、DOCX、PPT、PPTX、MD、TXT、XLS、
        /// XLSX、CSV、PNG、JPG、JPEG、BMP、GIF、WEBP、HEIC、EPS、ICNS、
        /// IM、PCX、PPM、TIFF、XBM、HEIF、JP2
        /// 
        /// 文档解析支持的文件大小：
        /// -PDF、DOC、DOCX、PPT、PPTX支持100M
        /// -MD、TXT、XLS、XLSX、CSV支特10M
        /// -其他支持20M
        /// 
        /// 文本切片支持的文件大小：
        /// -PDF最大300M
        /// -D0CX、D0C、PPT、PPTX最大200M
        /// -TXT、MD最大10M
        /// -其他最大20M
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 文件存储于腾讯云的 URL 可保障更高的下载速度和稳定性，使用腾讯云COS 文件地址。
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// 文件的 base64 值，携带 MineType前缀信息。编码后的后的文件不超过 10M。
        /// 支持的文件大小：所下载文件经Base64编码后不超过 8M。文件下载时间不超过3秒。
        /// 支持的图片像素：单边介于20-10000px之间。
        /// 文件的 FileUrl、FileContent必须提供一个，如果都提供只使用 FileUrl。
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// 文档解析配置
        /// </summary>
        [JsonProperty("DocumentParseConfig")]
        public DocumentParseConfig DocumentParseConfig{ get; set; }

        /// <summary>
        /// 文档的起始页码
        /// </summary>
        [JsonProperty("FileStartPageNumber")]
        public long? FileStartPageNumber{ get; set; }

        /// <summary>
        /// 文档的结束页码
        /// </summary>
        [JsonProperty("FileEndPageNumber")]
        public long? FileEndPageNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamObj(map, prefix + "DocumentParseConfig.", this.DocumentParseConfig);
            this.SetParamSimple(map, prefix + "FileStartPageNumber", this.FileStartPageNumber);
            this.SetParamSimple(map, prefix + "FileEndPageNumber", this.FileEndPageNumber);
        }
    }
}

