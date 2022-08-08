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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskInnerInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务名
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 工作流id
        /// </summary>
        [JsonProperty("WorkflowId")]
        public string WorkflowId{ get; set; }

        /// <summary>
        /// 周期类型  0:crontab类型, 1:分钟，2:小时，3:天，4:周，5:月，6:一次性，7:用户驱动，10:弹性周期 周,11:弹性周期 月,12:年,13:即时触发Instant类型，与正常周期调度任务逻辑隔离
        /// </summary>
        [JsonProperty("CycleType")]
        public long? CycleType{ get; set; }

        /// <summary>
        /// 虚拟任务id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirtualTaskId")]
        public string VirtualTaskId{ get; set; }

        /// <summary>
        /// 虚拟任务标记
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VirtualFlag")]
        public bool? VirtualFlag{ get; set; }

        /// <summary>
        /// 真实任务工作流id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealWorkflowId")]
        public string RealWorkflowId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "WorkflowId", this.WorkflowId);
            this.SetParamSimple(map, prefix + "CycleType", this.CycleType);
            this.SetParamSimple(map, prefix + "VirtualTaskId", this.VirtualTaskId);
            this.SetParamSimple(map, prefix + "VirtualFlag", this.VirtualFlag);
            this.SetParamSimple(map, prefix + "RealWorkflowId", this.RealWorkflowId);
        }
    }
}

