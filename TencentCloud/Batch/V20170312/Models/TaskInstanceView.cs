/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskInstanceView : AbstractModel
    {
        
        /// <summary>
        /// 任务实例索引
        /// </summary>
        [JsonProperty("TaskInstanceIndex")]
        public long? TaskInstanceIndex{ get; set; }

        /// <summary>
        /// 任务实例状态
        /// </summary>
        [JsonProperty("TaskInstanceState")]
        public string TaskInstanceState{ get; set; }

        /// <summary>
        /// 应用程序执行结束的exit code
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExitCode")]
        public long? ExitCode{ get; set; }

        /// <summary>
        /// 任务实例状态原因，任务实例失败时，会记录失败原因
        /// </summary>
        [JsonProperty("StateReason")]
        public string StateReason{ get; set; }

        /// <summary>
        /// 任务实例运行时所在计算节点（例如CVM）的InstanceId。任务实例未运行或者完结时，本字段为空。任务实例重试时，本字段会随之变化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComputeNodeInstanceId")]
        public string ComputeNodeInstanceId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 启动时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LaunchTime")]
        public string LaunchTime{ get; set; }

        /// <summary>
        /// 开始运行时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningTime")]
        public string RunningTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 重定向信息
        /// </summary>
        [JsonProperty("RedirectInfo")]
        public RedirectInfo RedirectInfo{ get; set; }

        /// <summary>
        /// 任务实例状态原因详情，任务实例失败时，会记录失败原因
        /// </summary>
        [JsonProperty("StateDetailedReason")]
        public string StateDetailedReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskInstanceIndex", this.TaskInstanceIndex);
            this.SetParamSimple(map, prefix + "TaskInstanceState", this.TaskInstanceState);
            this.SetParamSimple(map, prefix + "ExitCode", this.ExitCode);
            this.SetParamSimple(map, prefix + "StateReason", this.StateReason);
            this.SetParamSimple(map, prefix + "ComputeNodeInstanceId", this.ComputeNodeInstanceId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LaunchTime", this.LaunchTime);
            this.SetParamSimple(map, prefix + "RunningTime", this.RunningTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamObj(map, prefix + "RedirectInfo.", this.RedirectInfo);
            this.SetParamSimple(map, prefix + "StateDetailedReason", this.StateDetailedReason);
        }
    }
}

