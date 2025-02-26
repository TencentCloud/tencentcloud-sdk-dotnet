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

namespace TencentCloud.Lowcode.V20210108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadKnowledgeDocumentSetRequest : AbstractModel
    {
        
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
        /// 文件存储位置的可读地址
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
        /// 	文件元信息，为jsonstring
        /// </summary>
        [JsonProperty("FileMetaData")]
        public string FileMetaData{ get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        [JsonProperty("DocumentSetId")]
        public string DocumentSetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CollectionView", this.CollectionView);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "CosUrl", this.CosUrl);
            this.SetParamSimple(map, prefix + "DocumentType", this.DocumentType);
            this.SetParamSimple(map, prefix + "DocumentDesc", this.DocumentDesc);
            this.SetParamSimple(map, prefix + "FileTitle", this.FileTitle);
            this.SetParamSimple(map, prefix + "FileMetaData", this.FileMetaData);
            this.SetParamSimple(map, prefix + "DocumentSetId", this.DocumentSetId);
        }
    }
}

