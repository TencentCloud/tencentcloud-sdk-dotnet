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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAIGCTaskStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>状态</p><p>枚举值：</p><ul><li>FINISHED： 1</li></ul>
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// <p>输出url</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputUrl")]
        public string OutputUrl{ get; set; }

        /// <summary>
        /// <p>任务创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>任务调度时间</p>
        /// </summary>
        [JsonProperty("ScheduledTime")]
        public string ScheduledTime{ get; set; }

        /// <summary>
        /// <p>任务完成时间</p>
        /// </summary>
        [JsonProperty("FinishedTime")]
        public string FinishedTime{ get; set; }

        /// <summary>
        /// <p>任务错误码</p>
        /// </summary>
        [JsonProperty("TaskResultCode")]
        public long? TaskResultCode{ get; set; }

        /// <summary>
        /// <p>任务返回错误信息</p>
        /// </summary>
        [JsonProperty("TaskResultMsg")]
        public string TaskResultMsg{ get; set; }

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
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "OutputUrl", this.OutputUrl);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ScheduledTime", this.ScheduledTime);
            this.SetParamSimple(map, prefix + "FinishedTime", this.FinishedTime);
            this.SetParamSimple(map, prefix + "TaskResultCode", this.TaskResultCode);
            this.SetParamSimple(map, prefix + "TaskResultMsg", this.TaskResultMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

