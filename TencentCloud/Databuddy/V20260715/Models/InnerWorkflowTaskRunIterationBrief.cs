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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InnerWorkflowTaskRunIterationBrief : AbstractModel
    {
        
        /// <summary>
        /// <p>任务运行ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkflowTaskRunId")]
        public string WorkflowTaskRunId{ get; set; }

        /// <summary>
        /// <p>迭代序号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IterationIndex")]
        public string IterationIndex{ get; set; }

        /// <summary>
        /// <p>运行开始时间，单位：毫秒时间戳</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunStartTime")]
        public string RunStartTime{ get; set; }

        /// <summary>
        /// <p>运行结束时间，单位：毫秒时间戳</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunEndTime")]
        public string RunEndTime{ get; set; }

        /// <summary>
        /// <p>运行状态</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunState")]
        public string RunState{ get; set; }

        /// <summary>
        /// <p>运行时长，单位：秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunCostTime")]
        public string RunCostTime{ get; set; }

        /// <summary>
        /// <p>运行参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskParams")]
        public string TaskParams{ get; set; }

        /// <summary>
        /// <p>错误码</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorCodeString")]
        public string ErrorCodeString{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkflowTaskRunId", this.WorkflowTaskRunId);
            this.SetParamSimple(map, prefix + "IterationIndex", this.IterationIndex);
            this.SetParamSimple(map, prefix + "RunStartTime", this.RunStartTime);
            this.SetParamSimple(map, prefix + "RunEndTime", this.RunEndTime);
            this.SetParamSimple(map, prefix + "RunState", this.RunState);
            this.SetParamSimple(map, prefix + "RunCostTime", this.RunCostTime);
            this.SetParamSimple(map, prefix + "TaskParams", this.TaskParams);
            this.SetParamSimple(map, prefix + "ErrorCodeString", this.ErrorCodeString);
        }
    }
}

