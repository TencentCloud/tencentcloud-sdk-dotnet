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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExecutorTaskInstanceCount : AbstractModel
    {
        
        /// <summary>
        /// 执行资源组ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecutorGroupId")]
        public string ExecutorGroupId{ get; set; }

        /// <summary>
        /// 数据开发中的任务类型绑定的资源组数量等待调度的任务实例数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchedulingTaskCount")]
        public long? SchedulingTaskCount{ get; set; }

        /// <summary>
        /// 数据开发中的任务类型绑定的资源组数量运行中的人物实例数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningInstanceCount")]
        public long? RunningInstanceCount{ get; set; }

        /// <summary>
        /// 数据开发中的任务类型绑定的资源组数量等待运行的任务实例数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaitingInstanceCount")]
        public long? WaitingInstanceCount{ get; set; }

        /// <summary>
        /// 非离线开发调度中任务数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OthersTaskTypeSchedulingTaskCount")]
        public long? OthersTaskTypeSchedulingTaskCount{ get; set; }

        /// <summary>
        /// 非离线开发运行中实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OthersTaskTypeRunningInstanceCount")]
        public long? OthersTaskTypeRunningInstanceCount{ get; set; }

        /// <summary>
        /// 非离线开发等待运行实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OthersTaskTypeWaitingInstanceCount")]
        public string OthersTaskTypeWaitingInstanceCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExecutorGroupId", this.ExecutorGroupId);
            this.SetParamSimple(map, prefix + "SchedulingTaskCount", this.SchedulingTaskCount);
            this.SetParamSimple(map, prefix + "RunningInstanceCount", this.RunningInstanceCount);
            this.SetParamSimple(map, prefix + "WaitingInstanceCount", this.WaitingInstanceCount);
            this.SetParamSimple(map, prefix + "OthersTaskTypeSchedulingTaskCount", this.OthersTaskTypeSchedulingTaskCount);
            this.SetParamSimple(map, prefix + "OthersTaskTypeRunningInstanceCount", this.OthersTaskTypeRunningInstanceCount);
            this.SetParamSimple(map, prefix + "OthersTaskTypeWaitingInstanceCount", this.OthersTaskTypeWaitingInstanceCount);
        }
    }
}

