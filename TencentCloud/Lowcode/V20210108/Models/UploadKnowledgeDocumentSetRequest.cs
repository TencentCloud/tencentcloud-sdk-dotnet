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

namespace TencentCloud.Lowcode.V20210108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadKnowledgeDocumentSetRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 知识库标识
        /// </summary>
        [JsonProperty("CollectionView")]
        public string CollectionView{ get; set; }

        /// <summary>
        /// 状态;ENABLED启用；NOT_ENABLED不启用
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 腾讯云文件存储位置的可读地址
        /// </summary>
        [JsonProperty("CosUrl")]
        public string CosUrl{ get; set; }

        /// <summary>
        /// 文件类型，例如: .docx, .md
        /// </summary>
        [JsonProperty("DocumentType")]
        public string DocumentType{ get; set; }

        /// <summary>
        /// 对文件的描述
        /// </summary>
        [JsonProperty("DocumentDesc")]
        public string DocumentDesc{ get; set; }

        /// <summary>
        /// 文件标题
        /// </summary>
        [JsonProperty("FileTitle")]
        public string FileTitle{ get; set; }

        /// <summary>
        /// 文件元信息，为jsonstring
        /// </summary>
        [JsonProperty("FileMetaData")]
        public string FileMetaData{ get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        [JsonProperty("DocumentSetId")]
        public string DocumentSetId{ get; set; }

        /// <summary>
        /// 使用 regex 分割文档
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }

        /// <summary>
        /// Cos存储文件ID
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "CollectionView", this.CollectionView);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "CosUrl", this.CosUrl);
            this.SetParamSimple(map, prefix + "DocumentType", this.DocumentType);
            this.SetParamSimple(map, prefix + "DocumentDesc", this.DocumentDesc);
            this.SetParamSimple(map, prefix + "FileTitle", this.FileTitle);
            this.SetParamSimple(map, prefix + "FileMetaData", this.FileMetaData);
            this.SetParamSimple(map, prefix + "DocumentSetId", this.DocumentSetId);
            this.SetParamSimple(map, prefix + "Delimiter", this.Delimiter);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
        }
    }
}

