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

    public class KnowledgeBase : AbstractModel
    {
        
        /// <summary>
        /// 知识库id
        /// </summary>
        [JsonProperty("KnowledgeBaseId")]
        public string KnowledgeBaseId{ get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        [JsonProperty("KnowledgeBaseName")]
        public string KnowledgeBaseName{ get; set; }

        /// <summary>
        /// 知识库描述
        /// </summary>
        [JsonProperty("KnowledgeBaseDesc")]
        public string KnowledgeBaseDesc{ get; set; }

        /// <summary>
        /// 创建者subuin
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 文件数量
        /// </summary>
        [JsonProperty("FileNum")]
        public long? FileNum{ get; set; }

        /// <summary>
        /// 知识库关联的数据库列表，目前是只绑定一个数据源，数组预留拓展
        /// </summary>
        [JsonProperty("DatasourceIds")]
        public string[] DatasourceIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KnowledgeBaseId", this.KnowledgeBaseId);
            this.SetParamSimple(map, prefix + "KnowledgeBaseName", this.KnowledgeBaseName);
            this.SetParamSimple(map, prefix + "KnowledgeBaseDesc", this.KnowledgeBaseDesc);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "FileNum", this.FileNum);
            this.SetParamArraySimple(map, prefix + "DatasourceIds.", this.DatasourceIds);
        }
    }
}

