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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadDocRequest : AbstractModel
    {
        
        /// <summary>
        /// 知识库ID
        /// </summary>
        [JsonProperty("KnowledgeBaseId")]
        public string KnowledgeBaseId{ get; set; }

        /// <summary>
        /// 文件名。
        /// **需带文件类型后缀**
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 文件类型。
        /// 
        /// **支持的文件类型：**
        /// - `PDF`、`DOC`、`DOCX`、`XLS`、`XLSX`、`PPT`、`PPTX`、`MD`、`TXT`、`PNG`、`JPG`、`JPEG`、`CSV`
        /// 
        /// **支持的文件大小：**
        ///  - `PDF`、`DOCX`、`DOC`、`PPT`、`PPTX` 最大 200M
        ///  - `TXT`、`MD` 最大10M
        ///  - 其他 最大20M
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 文件的 URL 地址。
        /// 文件存储于腾讯云的 URL 可保障更高的下载速度和稳定性，建议文件存储于腾讯云。 非腾讯云存储的 URL 速度和稳定性可能受一定影响。
        /// 参考：[腾讯云COS文档](https://cloud.tencent.com/document/product/436/7749)
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// 属性标签引用
        /// </summary>
        [JsonProperty("AttributeLabel")]
        [System.Obsolete]
        public AttributeLabelReferItem[] AttributeLabel{ get; set; }

        /// <summary>
        /// 属性标签引用
        /// </summary>
        [JsonProperty("AttributeLabels")]
        public AttributeLabelReferItem[] AttributeLabels{ get; set; }

        /// <summary>
        /// 分段信息
        /// </summary>
        [JsonProperty("Config")]
        public SegmentationConfig Config{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KnowledgeBaseId", this.KnowledgeBaseId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamArrayObj(map, prefix + "AttributeLabel.", this.AttributeLabel);
            this.SetParamArrayObj(map, prefix + "AttributeLabels.", this.AttributeLabels);
            this.SetParamObj(map, prefix + "Config.", this.Config);
        }
    }
}

