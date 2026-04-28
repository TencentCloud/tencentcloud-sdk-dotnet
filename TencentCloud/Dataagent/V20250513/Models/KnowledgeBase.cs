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
        /// <p>知识库id</p>
        /// </summary>
        [JsonProperty("KnowledgeBaseId")]
        public string KnowledgeBaseId{ get; set; }

        /// <summary>
        /// <p>知识库名称</p>
        /// </summary>
        [JsonProperty("KnowledgeBaseName")]
        public string KnowledgeBaseName{ get; set; }

        /// <summary>
        /// <p>知识库描述</p>
        /// </summary>
        [JsonProperty("KnowledgeBaseDesc")]
        public string KnowledgeBaseDesc{ get; set; }

        /// <summary>
        /// <p>创建者subuin</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>文件数量</p>
        /// </summary>
        [JsonProperty("FileNum")]
        public long? FileNum{ get; set; }

        /// <summary>
        /// <p>知识库关联的数据库列表，目前是只绑定一个数据源，数组预留拓展</p>
        /// </summary>
        [JsonProperty("DatasourceIds")]
        public string[] DatasourceIds{ get; set; }

        /// <summary>
        /// <p>知识库任务配置</p>
        /// </summary>
        [JsonProperty("Config")]
        public KnowledgeTaskConfig Config{ get; set; }


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
            this.SetParamObj(map, prefix + "Config.", this.Config);
        }
    }
}

