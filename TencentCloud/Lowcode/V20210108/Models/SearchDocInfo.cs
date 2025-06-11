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

    public class SearchDocInfo : AbstractModel
    {
        
        /// <summary>
        /// 知识库名称
        /// </summary>
        [JsonProperty("CollectionViewName")]
        public string CollectionViewName{ get; set; }

        /// <summary>
        /// 文档Id
        /// </summary>
        [JsonProperty("DocSetId")]
        public string DocSetId{ get; set; }

        /// <summary>
        /// 文档Name
        /// </summary>
        [JsonProperty("DocSetName")]
        public string DocSetName{ get; set; }

        /// <summary>
        /// 文档类型
        /// </summary>
        [JsonProperty("DocType")]
        public string DocType{ get; set; }

        /// <summary>
        /// 文档标题
        /// </summary>
        [JsonProperty("FileTitle")]
        public string FileTitle{ get; set; }

        /// <summary>
        /// 文档元信息
        /// </summary>
        [JsonProperty("FileMetaData")]
        public string FileMetaData{ get; set; }

        /// <summary>
        /// 文档描述
        /// </summary>
        [JsonProperty("DocDesc")]
        public string DocDesc{ get; set; }

        /// <summary>
        /// 文档大小
        /// </summary>
        [JsonProperty("FileSize")]
        public ulong? FileSize{ get; set; }

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
            this.SetParamSimple(map, prefix + "CollectionViewName", this.CollectionViewName);
            this.SetParamSimple(map, prefix + "DocSetId", this.DocSetId);
            this.SetParamSimple(map, prefix + "DocSetName", this.DocSetName);
            this.SetParamSimple(map, prefix + "DocType", this.DocType);
            this.SetParamSimple(map, prefix + "FileTitle", this.FileTitle);
            this.SetParamSimple(map, prefix + "FileMetaData", this.FileMetaData);
            this.SetParamSimple(map, prefix + "DocDesc", this.DocDesc);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
        }
    }
}

