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

    public class SubmitMultimodalDocParseJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>支持解析的文件类型。取值：</p><ul><li>1：PDF 文档</li><li>2：Word 文档（.doc/.docx）</li><li>3：PPT 演示文稿（.ppt/.pptx）</li><li>4：Excel 表格（.xls/.xlsx）</li><li>5：Markdown 文档（.md）</li><li>6：纯文本文件（.txt）</li><li>7：图片文件（.png/.jpg/.jpeg 等）</li><li>8：WPS 文档<br>支持的文件大小：PDF/WORD/PPT 支持 150M 且 300 页。</li></ul>
        /// </summary>
        [JsonProperty("FileType")]
        public long? FileType{ get; set; }

        /// <summary>
        /// <p>文件的 Url 地址，支持 FileType 参数对应的文件格式及大小。文件下载时间不超过 3 秒。文件存储于腾讯云的 Url 可保障更高的下载速度和稳定性，建议文件存储于腾讯云。非腾讯云存储的 Url 速度和稳定性可能受一定影响。</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// <p>文件的 Base64 值。支持 FileType 参数对应的文件格式，支持的文件大小不超过 8M。文件下载时间不超过 3 秒。<br>文件的 FileUrl、FileBase64 必须提供一个，如果都提供，只使用 FileUrl。</p>
        /// </summary>
        [JsonProperty("FileBase64")]
        public string FileBase64{ get; set; }

        /// <summary>
        /// <p>输出格式。<br>1：json格式<br>2：markdown格式<br>3：xml格式<br>9：json+markdown+xml格式</p>
        /// </summary>
        [JsonProperty("ResultType")]
        public long? ResultType{ get; set; }

        /// <summary>
        /// <p>是否开启子图提取，默认为 false。</p>
        /// </summary>
        [JsonProperty("EnableSubImg")]
        public bool? EnableSubImg{ get; set; }

        /// <summary>
        /// <p>文档的起始页码。用来指定识别的起始页码，识别的页码包含当前值，不填时默认从文档第一页开始解析。本参数与 FileEndPageNumber 可分开填写，也可只填其中一个。</p>
        /// </summary>
        [JsonProperty("FileStartPageNumber")]
        public long? FileStartPageNumber{ get; set; }

        /// <summary>
        /// <p>文档的结束页码。用来指定识别的结束页码，识别的页码包含当前值，不填时默认解析到文档最后一页。本参数与 FileStartPageNumber 可分开填写，也可只填其中一个。</p>
        /// </summary>
        [JsonProperty("FileEndPageNumber")]
        public long? FileEndPageNumber{ get; set; }

        /// <summary>
        /// <p>任务类型，默认为 0。取值：</p><ul><li>0：默认</li><li>1：Free OCR</li><li>2：OCR</li><li>3：表格识别</li><li>4：代码识别</li></ul>
        /// </summary>
        [JsonProperty("TaskType")]
        public long? TaskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "FileBase64", this.FileBase64);
            this.SetParamSimple(map, prefix + "ResultType", this.ResultType);
            this.SetParamSimple(map, prefix + "EnableSubImg", this.EnableSubImg);
            this.SetParamSimple(map, prefix + "FileStartPageNumber", this.FileStartPageNumber);
            this.SetParamSimple(map, prefix + "FileEndPageNumber", this.FileEndPageNumber);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
        }
    }
}

