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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateTaskBrief : AbstractModel
    {
        
        /// <summary>
        /// 任务基本属性
        /// </summary>
        [JsonProperty("TaskBaseAttribute")]
        public UpdateTaskBaseAttribute TaskBaseAttribute{ get; set; }

        /// <summary>
        /// 任务配置
        /// </summary>
        [JsonProperty("TaskConfiguration")]
        public TaskConfiguration TaskConfiguration{ get; set; }

        /// <summary>
        /// 任务调度配置
        /// </summary>
        [JsonProperty("TaskSchedulerConfiguration")]
        public TaskSchedulerConfiguration TaskSchedulerConfiguration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "TaskBaseAttribute.", this.TaskBaseAttribute);
            this.SetParamObj(map, prefix + "TaskConfiguration.", this.TaskConfiguration);
            this.SetParamObj(map, prefix + "TaskSchedulerConfiguration.", this.TaskSchedulerConfiguration);
        }
    }
}

