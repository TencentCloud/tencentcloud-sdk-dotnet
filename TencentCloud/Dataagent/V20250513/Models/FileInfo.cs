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

namespace TencentCloud.Dataagent.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>文件名称</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>文件大小，字节</p>
        /// </summary>
        [JsonProperty("FileSize")]
        public float? FileSize{ get; set; }

        /// <summary>
        /// <p>文件类型,0=文本,1=表格，默认0</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>文件ID</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>状态，0：数据处理中  1：可用 -1：错误</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>操作者</p>
        /// </summary>
        [JsonProperty("CreateUser")]
        public string CreateUser{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>分片策略</p>
        /// </summary>
        [JsonProperty("ChunkConfig")]
        public KnowledgeTaskConfig ChunkConfig{ get; set; }

        /// <summary>
        /// <p>文件来源0=unknow,1=user_cos,2=local</p>
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// <p>文件url</p>
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// <p>是否官方示例，0=否，1=是</p>
        /// </summary>
        [JsonProperty("IsShowCase")]
        public long? IsShowCase{ get; set; }

        /// <summary>
        /// <p>文档摘要</p>
        /// </summary>
        [JsonProperty("DocumentSummary")]
        public string DocumentSummary{ get; set; }

        /// <summary>
        /// <p>网页地址</p>
        /// </summary>
        [JsonProperty("WebUrl")]
        public string WebUrl{ get; set; }

        /// <summary>
        /// <p>文件能力标识列表</p>
        /// </summary>
        [JsonProperty("Capabilities")]
        public string[] Capabilities{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateUser", this.CreateUser);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "ChunkConfig.", this.ChunkConfig);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "IsShowCase", this.IsShowCase);
            this.SetParamSimple(map, prefix + "DocumentSummary", this.DocumentSummary);
            this.SetParamSimple(map, prefix + "WebUrl", this.WebUrl);
            this.SetParamArraySimple(map, prefix + "Capabilities.", this.Capabilities);
        }
    }
}

