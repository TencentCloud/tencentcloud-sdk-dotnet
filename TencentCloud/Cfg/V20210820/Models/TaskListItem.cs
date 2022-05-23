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

    public class TaskListItem : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// 任务标题
        /// </summary>
        [JsonProperty("TaskTitle")]
        public string TaskTitle{ get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [JsonProperty("TaskDescription")]
        public string TaskDescription{ get; set; }

        /// <summary>
        /// 任务标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTag")]
        public string TaskTag{ get; set; }

        /// <summary>
        /// 任务状态(1001 -- 未开始   1002 -- 进行中  1003 -- 暂停中   1004 -- 任务结束)
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("TaskCreateTime")]
        public string TaskCreateTime{ get; set; }

        /// <summary>
        /// 任务更新时间
        /// </summary>
        [JsonProperty("TaskUpdateTime")]
        public string TaskUpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskTitle", this.TaskTitle);
            this.SetParamSimple(map, prefix + "TaskDescription", this.TaskDescription);
            this.SetParamSimple(map, prefix + "TaskTag", this.TaskTag);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskCreateTime", this.TaskCreateTime);
            this.SetParamSimple(map, prefix + "TaskUpdateTime", this.TaskUpdateTime);
        }
    }
}

