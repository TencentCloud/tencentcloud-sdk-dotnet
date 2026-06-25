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

    public class MultimodalDocParseRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>文件的 Url 地址，支持FileType参数对应的文件格式及大小。文件下载时间不超过3秒。文件存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议文件存储于腾讯云。非腾讯云存储的 Url 速度和稳定性可能受一定影响。</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// <p>支持解析的文件类型。</p><p>1：PDF 文档；</p><p>2：Word 文档（.doc / .docx）；</p><p>3：PPT 演示文稿（.ppt / .pptx）；</p><p>4：Excel 表格（.xls / .xlsx）；</p><p>5：Markdown 文档（.md）；</p><p>6：纯文本文件（.txt）；</p><p>7：图片文件（.png / .jpg / .jpeg 等）；</p><p>8：WPS 文档；</p><p>0：未知文件类型。</p><p></p><p>支持的文件大小：</p><p>PDF/WORD/PPT支持150M且300页以内、EXCEL支持10M以内、TXT支持10M以内、图片文件支持70M以内。</p><p></p><p>默认值：1</p>
        /// </summary>
        [JsonProperty("FileType")]
        public long? FileType{ get; set; }

        /// <summary>
        /// <p>输出格式。</p><p>1：json格式</p><p>2：markdown格式</p><p>3：xml格式</p><p>9：json+markdown+xml格式</p><p></p><p>默认值：9</p>
        /// </summary>
        [JsonProperty("ResultType")]
        public long? ResultType{ get; set; }

        /// <summary>
        /// <p>是否支持子图解析。</p><p></p><p>默认值：false</p>
        /// </summary>
        [JsonProperty("EnableSubImg")]
        public bool? EnableSubImg{ get; set; }

        /// <summary>
        /// <p>需要识别的页码范围，单次调用最多支持300页。</p><p>参数格式：1-10</p>
        /// </summary>
        [JsonProperty("PageRange")]
        public string PageRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "ResultType", this.ResultType);
            this.SetParamSimple(map, prefix + "EnableSubImg", this.EnableSubImg);
            this.SetParamSimple(map, prefix + "PageRange", this.PageRange);
        }
    }
}

