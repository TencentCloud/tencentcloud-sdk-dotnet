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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskGroupInstance : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("TaskGroupInstanceId")]
        public long? TaskGroupInstanceId{ get; set; }

        /// <summary>
        /// 实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskGroupInstanceObjectId")]
        public string TaskGroupInstanceObjectId{ get; set; }

        /// <summary>
        /// 实例动作执行状态
        /// </summary>
        [JsonProperty("TaskGroupInstanceStatus")]
        public long? TaskGroupInstanceStatus{ get; set; }

        /// <summary>
        /// 实例动作执行日志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskGroupInstanceExecuteLog")]
        public string TaskGroupInstanceExecuteLog{ get; set; }

        /// <summary>
        /// 实例创建时间
        /// </summary>
        [JsonProperty("TaskGroupInstanceCreateTime")]
        public string TaskGroupInstanceCreateTime{ get; set; }

        /// <summary>
        /// 实例更新时间
        /// </summary>
        [JsonProperty("TaskGroupInstanceUpdateTime")]
        public string TaskGroupInstanceUpdateTime{ get; set; }

        /// <summary>
        /// 状态类型: 0 -- 无状态，1 -- 成功，2-- 失败，3--终止，4--跳过
        /// </summary>
        [JsonProperty("TaskGroupInstanceStatusType")]
        public long? TaskGroupInstanceStatusType{ get; set; }

        /// <summary>
        /// 执行开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskGroupInstanceStartTime")]
        public string TaskGroupInstanceStartTime{ get; set; }

        /// <summary>
        /// 执行结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskGroupInstanceEndTime")]
        public string TaskGroupInstanceEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskGroupInstanceId", this.TaskGroupInstanceId);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceObjectId", this.TaskGroupInstanceObjectId);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceStatus", this.TaskGroupInstanceStatus);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceExecuteLog", this.TaskGroupInstanceExecuteLog);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceCreateTime", this.TaskGroupInstanceCreateTime);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceUpdateTime", this.TaskGroupInstanceUpdateTime);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceStatusType", this.TaskGroupInstanceStatusType);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceStartTime", this.TaskGroupInstanceStartTime);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceEndTime", this.TaskGroupInstanceEndTime);
        }
    }
}

