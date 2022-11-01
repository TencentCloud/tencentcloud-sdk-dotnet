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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// 文件对应业务类型
        /// 1. TEMPLATE - 模板； 文件类型：.pdf/.doc/.docx/.html
        /// 2. DOCUMENT - 签署过程及签署后的合同文档/图片控件 文件类型：.pdf/.doc/.docx/.jpg/.png/.xls.xlsx/.html
        /// 3. SEAL - 印章； 文件类型：.jpg/.jpeg/.png
        /// </summary>
        [JsonProperty("BusinessType")]
        public string BusinessType{ get; set; }

        /// <summary>
        /// 调用方信息
        /// </summary>
        [JsonProperty("Caller")]
        public Caller Caller{ get; set; }

        /// <summary>
        /// 上传文件内容数组，最多支持20个文件
        /// </summary>
        [JsonProperty("FileInfos")]
        public UploadFile[] FileInfos{ get; set; }

        /// <summary>
        /// 不再使用，上传文件链接数组，最多支持20个URL
        /// </summary>
        [JsonProperty("FileUrls")]
        public string FileUrls{ get; set; }

        /// <summary>
        /// 此参数只对 PDF 文件有效。是否将pdf灰色矩阵置白
        /// true--是，处理置白
        /// false--否，不处理
        /// </summary>
        [JsonProperty("CoverRect")]
        public bool? CoverRect{ get; set; }

        /// <summary>
        /// 文件类型， 默认通过文件内容解析得到文件类型，客户可以显示的说明上传文件的类型。
        /// 如：PDF 表示上传的文件 xxx.pdf的文件类型是 PDF
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 用户自定义ID数组，与上传文件一一对应
        /// </summary>
        [JsonProperty("CustomIds")]
        public string[] CustomIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BusinessType", this.BusinessType);
            this.SetParamObj(map, prefix + "Caller.", this.Caller);
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamSimple(map, prefix + "FileUrls", this.FileUrls);
            this.SetParamSimple(map, prefix + "CoverRect", this.CoverRect);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamArraySimple(map, prefix + "CustomIds.", this.CustomIds);
        }
    }
}

