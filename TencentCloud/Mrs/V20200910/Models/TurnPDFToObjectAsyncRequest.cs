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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TurnPDFToObjectAsyncRequest : AbstractModel
    {
        
        /// <summary>
        /// 体检报告PDF文件信息, 目前只支持传PDF文件的Base64编码字符(PDF文件不能超过10MB，如果超过建议先压缩PDF，再转成base64)
        /// </summary>
        [JsonProperty("PdfInfo")]
        public PdfInfo PdfInfo{ get; set; }

        /// <summary>
        /// PDF文件中的文字是否为文本内容.
        /// 如果该字段为true,那么就会自动判断是电子版还是图片，自动选择直接读取文字还是 OCR 方式.
        /// 如果该字段为false, 那么始终采用 OCR 方式
        /// </summary>
        [JsonProperty("TextBasedPdfFlag")]
        public bool? TextBasedPdfFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "PdfInfo.", this.PdfInfo);
            this.SetParamSimple(map, prefix + "TextBasedPdfFlag", this.TextBasedPdfFlag);
        }
    }
}

