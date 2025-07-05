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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务信息，不包含任务结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskInfo")]
        public TaskInfo TaskInfo{ get; set; }

        /// <summary>
        /// 视频任务结果数据，只在视频任务结束时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskData")]
        public Data TaskData{ get; set; }

        /// <summary>
        /// 图片任务结果数据，只在图片任务结束时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageTaskData")]
        public ImageData ImageTaskData{ get; set; }

        /// <summary>
        /// 音频任务结果数据，只在音频任务结束时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AudioTaskData")]
        public AudioData AudioTaskData{ get; set; }

        /// <summary>
        /// 文本任务结果数据，只在文本任务结束时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TextTaskData")]
        public TextData TextTaskData{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TaskInfo.", this.TaskInfo);
            this.SetParamObj(map, prefix + "TaskData.", this.TaskData);
            this.SetParamObj(map, prefix + "ImageTaskData.", this.ImageTaskData);
            this.SetParamObj(map, prefix + "AudioTaskData.", this.AudioTaskData);
            this.SetParamObj(map, prefix + "TextTaskData.", this.TextTaskData);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

