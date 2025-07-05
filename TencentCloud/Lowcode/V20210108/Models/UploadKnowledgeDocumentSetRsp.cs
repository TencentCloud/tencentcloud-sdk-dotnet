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

    public class UploadKnowledgeDocumentSetRsp : AbstractModel
    {
        
        /// <summary>
        /// 给文件分配的 ID 信息。
        /// </summary>
        [JsonProperty("DocumentSetId")]
        [System.Obsolete]
        public string DocumentSetId{ get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("DocumentSetName")]
        public string DocumentSetName{ get; set; }

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
        /// Cos存储文件ID
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DocumentSetId", this.DocumentSetId);
            this.SetParamSimple(map, prefix + "DocumentSetName", this.DocumentSetName);
            this.SetParamSimple(map, prefix + "FileTitle", this.FileTitle);
            this.SetParamSimple(map, prefix + "FileMetaData", this.FileMetaData);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
        }
    }
}

