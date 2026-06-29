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

    public class KnowledgeAnalysisResult : AbstractModel
    {
        
        /// <summary>
        /// <p>处理任务类型</p><p>枚举值：</p><ul><li>AiAnalysis.DescriptionTask： 智能摘要任务</li><li>AiAnalysis.VideoComprehensionTask： 视频理解任务</li><li>SmartSubtitle.AsrFullTextTask： 智能语音全文识别任务</li></ul>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>任务输出文件集合</p>
        /// </summary>
        [JsonProperty("File")]
        public MPSOutputFileInfo File{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamObj(map, prefix + "File.", this.File);
        }
    }
}

