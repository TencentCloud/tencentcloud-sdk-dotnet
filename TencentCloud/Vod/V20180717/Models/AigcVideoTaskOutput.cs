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

    public class AigcVideoTaskOutput : AbstractModel
    {
        
        /// <summary>
        /// <p>AIGC 生视频任务的输出文件信息。</p>
        /// </summary>
        [JsonProperty("FileInfos")]
        public AigcVideoTaskOutputFileInfo[] FileInfos{ get; set; }

        /// <summary>
        /// <p>任务类型为 Procedure 的任务 ID。若发起<a href="https://cloud.tencent.com/document/product/266/126239">创建 AIGC 生视频任务</a>时指定了任务流模板(Procedure)，当该任务流模板指定了 MediaProcessTask、AiAnalysisTask、AiRecognitionTask 中的一个或多个时发起该任务。</p>
        /// </summary>
        [JsonProperty("ProcedureTaskIds")]
        public string[] ProcedureTaskIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "FileInfos.", this.FileInfos);
            this.SetParamArraySimple(map, prefix + "ProcedureTaskIds.", this.ProcedureTaskIds);
        }
    }
}

