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

    public class Job : AbstractModel
    {
        
        /// <summary>
        /// 任务信息
        /// </summary>
        [JsonProperty("Tasks")]
        public Task[] Tasks{ get; set; }

        /// <summary>
        /// 作业名称
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 作业描述
        /// </summary>
        [JsonProperty("JobDescription")]
        public string JobDescription{ get; set; }

        /// <summary>
        /// 作业优先级，任务（Task）和任务实例（TaskInstance）会继承作业优先级
        /// </summary>
        [JsonProperty("Priority")]
        public ulong? Priority{ get; set; }

        /// <summary>
        /// 依赖信息
        /// </summary>
        [JsonProperty("Dependences")]
        public Dependence[] Dependences{ get; set; }

        /// <summary>
        /// 通知信息
        /// </summary>
        [JsonProperty("Notifications")]
        public Notification[] Notifications{ get; set; }

        /// <summary>
        /// 对于存在依赖关系的任务中，后序任务执行对于前序任务的依赖条件。取值范围包括 PRE_TASK_SUCCEED，PRE_TASK_AT_LEAST_PARTLY_SUCCEED，PRE_TASK_FINISHED，默认值为PRE_TASK_SUCCEED。
        /// </summary>
        [JsonProperty("TaskExecutionDependOn")]
        public string TaskExecutionDependOn{ get; set; }

        /// <summary>
        /// 表示创建 CVM 失败按照何种策略处理。取值范围包括 FAILED，RUNNABLE。FAILED 表示创建 CVM 失败按照一次执行失败处理，RUNNABLE 表示创建 CVM 失败按照继续等待处理。默认值为FAILED。StateIfCreateCvmFailed对于提交的指定计算环境的作业无效。
        /// </summary>
        [JsonProperty("StateIfCreateCvmFailed")]
        public string StateIfCreateCvmFailed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "JobDescription", this.JobDescription);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamArrayObj(map, prefix + "Dependences.", this.Dependences);
            this.SetParamArrayObj(map, prefix + "Notifications.", this.Notifications);
            this.SetParamSimple(map, prefix + "TaskExecutionDependOn", this.TaskExecutionDependOn);
            this.SetParamSimple(map, prefix + "StateIfCreateCvmFailed", this.StateIfCreateCvmFailed);
        }
    }
}

