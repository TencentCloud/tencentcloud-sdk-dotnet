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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TasksOverview : AbstractModel
    {
        
        /// <summary>
        /// 正在排队的任务个数
        /// </summary>
        [JsonProperty("TaskQueuedCount")]
        public long? TaskQueuedCount{ get; set; }

        /// <summary>
        /// 初始化的任务个数
        /// </summary>
        [JsonProperty("TaskInitCount")]
        public long? TaskInitCount{ get; set; }

        /// <summary>
        /// 正在执行的任务个数
        /// </summary>
        [JsonProperty("TaskRunningCount")]
        public long? TaskRunningCount{ get; set; }

        /// <summary>
        /// 当前时间范围的总任务个数
        /// </summary>
        [JsonProperty("TotalTaskCount")]
        public long? TotalTaskCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskQueuedCount", this.TaskQueuedCount);
            this.SetParamSimple(map, prefix + "TaskInitCount", this.TaskInitCount);
            this.SetParamSimple(map, prefix + "TaskRunningCount", this.TaskRunningCount);
            this.SetParamSimple(map, prefix + "TotalTaskCount", this.TotalTaskCount);
        }
    }
}

