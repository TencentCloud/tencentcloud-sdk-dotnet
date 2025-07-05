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

    public class ExecuteTaskInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 任务动作ID
        /// </summary>
        [JsonProperty("TaskActionId")]
        public ulong? TaskActionId{ get; set; }

        /// <summary>
        /// 任务动作实例ID
        /// </summary>
        [JsonProperty("TaskInstanceIds")]
        public ulong?[] TaskInstanceIds{ get; set; }

        /// <summary>
        /// 是否操作整个任务
        /// </summary>
        [JsonProperty("IsOperateAll")]
        public bool? IsOperateAll{ get; set; }

        /// <summary>
        /// 操作类型：（1--启动   2--执行  3--跳过   5--重试）
        /// </summary>
        [JsonProperty("ActionType")]
        public ulong? ActionType{ get; set; }

        /// <summary>
        /// 动作组ID
        /// </summary>
        [JsonProperty("TaskGroupId")]
        public ulong? TaskGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskActionId", this.TaskActionId);
            this.SetParamArraySimple(map, prefix + "TaskInstanceIds.", this.TaskInstanceIds);
            this.SetParamSimple(map, prefix + "IsOperateAll", this.IsOperateAll);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "TaskGroupId", this.TaskGroupId);
        }
    }
}

