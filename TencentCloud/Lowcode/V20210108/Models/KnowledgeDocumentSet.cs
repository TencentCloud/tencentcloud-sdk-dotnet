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

    public class KnowledgeDocumentSet : AbstractModel
    {
        
        /// <summary>
        /// 文档id
        /// </summary>
        [JsonProperty("DocumentSetId")]
        public string DocumentSetId{ get; set; }

        /// <summary>
        /// 文档名
        /// </summary>
        [JsonProperty("DocumentSetName")]
        public string DocumentSetName{ get; set; }

        /// <summary>
        /// 文件完整内容。
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// 文件内容前 200个字符。
        /// </summary>
        [JsonProperty("TextPrefix")]
        public string TextPrefix{ get; set; }

        /// <summary>
        /// 文件详情
        /// </summary>
        [JsonProperty("DocumentSetInfo")]
        public KnowledgeDocumentSetInfo DocumentSetInfo{ get; set; }

        /// <summary>
        /// 文件拆分信息
        /// </summary>
        [JsonProperty("SplitterPreprocess")]
        public KnowledgeSplitterPreprocess SplitterPreprocess{ get; set; }

        /// <summary>
        /// 未使用
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 文档标题
        /// </summary>
        [JsonProperty("FileTitle")]
        public string FileTitle{ get; set; }

        /// <summary>
        /// 文档元信息，必须为jsonstring
        /// </summary>
        [JsonProperty("FileMetaData")]
        public string FileMetaData{ get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [JsonProperty("Author")]
        public string Author{ get; set; }

        /// <summary>
        /// 上传文件状态
        /// </summary>
        [JsonProperty("DocStatus")]
        public string DocStatus{ get; set; }

        /// <summary>
        /// 文件上传失败的具体原因
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

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
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "TextPrefix", this.TextPrefix);
            this.SetParamObj(map, prefix + "DocumentSetInfo.", this.DocumentSetInfo);
            this.SetParamObj(map, prefix + "SplitterPreprocess.", this.SplitterPreprocess);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "FileTitle", this.FileTitle);
            this.SetParamSimple(map, prefix + "FileMetaData", this.FileMetaData);
            this.SetParamSimple(map, prefix + "Author", this.Author);
            this.SetParamSimple(map, prefix + "DocStatus", this.DocStatus);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
        }
    }
}

