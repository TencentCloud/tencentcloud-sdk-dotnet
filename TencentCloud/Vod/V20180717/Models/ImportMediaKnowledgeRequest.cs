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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImportMediaKnowledgeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>点播<a href="/document/product/266/14574">应用</a> ID。</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>媒体文件 ID，即该文件在云点播上的全局唯一标识符，在上传成功后由云点播后台分配。可以在 <a href="/document/product/266/7830">视频上传完成事件通知</a> 或 <a href="https://console.cloud.tencent.com/vod/media">云点播控制台</a> 获取该字段。</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>大模型理解模板的唯一标识</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>知识库ID列表，留空时将使用默认知识库</p>
        /// </summary>
        [JsonProperty("KnowledgeBaseIds")]
        public string[] KnowledgeBaseIds{ get; set; }

        /// <summary>
        /// <p>需要导入知识库任务类型，可选值有：</p><ul><li>AiAnalysis.DescriptionTask</li><li>SmartSubtitle.AsrFullTextTask</li></ul>
        /// </summary>
        [JsonProperty("ImportTasks")]
        [System.Obsolete]
        public string[] ImportTasks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamArraySimple(map, prefix + "KnowledgeBaseIds.", this.KnowledgeBaseIds);
            this.SetParamArraySimple(map, prefix + "ImportTasks.", this.ImportTasks);
        }
    }
}

