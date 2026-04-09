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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskGroupInstance : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("TaskGroupInstanceId")]
        public long? TaskGroupInstanceId{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("TaskGroupInstanceObjectId")]
        public string TaskGroupInstanceObjectId{ get; set; }

        /// <summary>
        /// <p>实例动作执行状态</p><p>枚举值：</p><ul><li>3001： 未开始</li><li>3002： 执行中</li><li>3003： 执行结束</li><li>3004： 准备中</li></ul>
        /// </summary>
        [JsonProperty("TaskGroupInstanceStatus")]
        public long? TaskGroupInstanceStatus{ get; set; }

        /// <summary>
        /// <p>实例创建时间</p>
        /// </summary>
        [JsonProperty("TaskGroupInstanceCreateTime")]
        public string TaskGroupInstanceCreateTime{ get; set; }

        /// <summary>
        /// <p>实例更新时间</p>
        /// </summary>
        [JsonProperty("TaskGroupInstanceUpdateTime")]
        public string TaskGroupInstanceUpdateTime{ get; set; }

        /// <summary>
        /// <p>状态类型: 0 -- 无状态，1 -- 成功，2-- 失败，3--终止，4--跳过</p>
        /// </summary>
        [JsonProperty("TaskGroupInstanceStatusType")]
        public long? TaskGroupInstanceStatusType{ get; set; }

        /// <summary>
        /// <p>执行开始时间</p>
        /// </summary>
        [JsonProperty("TaskGroupInstanceStartTime")]
        public string TaskGroupInstanceStartTime{ get; set; }

        /// <summary>
        /// <p>执行结束时间</p>
        /// </summary>
        [JsonProperty("TaskGroupInstanceEndTime")]
        public string TaskGroupInstanceEndTime{ get; set; }

        /// <summary>
        /// <p>实例动作执行日志</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskGroupInstanceExecuteLog")]
        [System.Obsolete]
        public string TaskGroupInstanceExecuteLog{ get; set; }

        /// <summary>
        /// <p>实例是否可重试</p>
        /// </summary>
        [JsonProperty("TaskGroupInstanceIsRedo")]
        public bool? TaskGroupInstanceIsRedo{ get; set; }

        /// <summary>
        /// <p>动作实例执行时间</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("TaskGroupInstanceExecuteTime")]
        public long? TaskGroupInstanceExecuteTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskGroupInstanceId", this.TaskGroupInstanceId);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceObjectId", this.TaskGroupInstanceObjectId);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceStatus", this.TaskGroupInstanceStatus);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceCreateTime", this.TaskGroupInstanceCreateTime);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceUpdateTime", this.TaskGroupInstanceUpdateTime);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceStatusType", this.TaskGroupInstanceStatusType);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceStartTime", this.TaskGroupInstanceStartTime);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceEndTime", this.TaskGroupInstanceEndTime);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceExecuteLog", this.TaskGroupInstanceExecuteLog);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceIsRedo", this.TaskGroupInstanceIsRedo);
            this.SetParamSimple(map, prefix + "TaskGroupInstanceExecuteTime", this.TaskGroupInstanceExecuteTime);
        }
    }
}

