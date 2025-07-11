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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务状态，取值有：
        /// <li>PROCESSING：处理中：</li>
        /// <li>SUCCESS：成功；</li>
        /// <li>FAIL：失败。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 任务进度，取值为：0~100。
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// 错误码。
        /// <li>0：成功；</li>
        /// <li>其他值：失败。</li>
        /// </summary>
        [JsonProperty("ErrCode")]
        public ulong? ErrCode{ get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

        /// <summary>
        /// 任务类型，取值有：
        /// <li>VIDEO_EDIT_PROJECT_EXPORT：视频编辑项目导出。</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 导出项目输出信息。仅当 TaskType 为 VIDEO_EDIT_PROJECT_EXPORT 时有效。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoEditProjectOutput")]
        public VideoEditProjectOutput VideoEditProjectOutput{ get; set; }

        /// <summary>
        /// 创建时间，格式按照 ISO 8601 标准表示。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamObj(map, prefix + "VideoEditProjectOutput.", this.VideoEditProjectOutput);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

