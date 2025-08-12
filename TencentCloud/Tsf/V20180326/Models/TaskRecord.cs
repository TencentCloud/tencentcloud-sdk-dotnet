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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskRecord : AbstractModel
    {
        
        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 任务执行方式，unicast：随机单节点执行，broadcast：广播执行，shard：分片执行
        /// </summary>
        [JsonProperty("ExecuteType")]
        public string ExecuteType{ get; set; }

        /// <summary>
        /// 任务内容，长度限制65535字节
        /// </summary>
        [JsonProperty("TaskContent")]
        public string TaskContent{ get; set; }

        /// <summary>
        /// 分组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 超时时间，单位：毫秒。
        /// </summary>
        [JsonProperty("TimeOut")]
        public long? TimeOut{ get; set; }

        /// <summary>
        /// 重试次数
        /// </summary>
        [JsonProperty("RetryCount")]
        public long? RetryCount{ get; set; }

        /// <summary>
        /// 重试间隔，单位：毫秒。
        /// </summary>
        [JsonProperty("RetryInterval")]
        public long? RetryInterval{ get; set; }

        /// <summary>
        /// 触发规则
        /// </summary>
        [JsonProperty("TaskRule")]
        public TaskRule TaskRule{ get; set; }

        /// <summary>
        /// 任务启用状态。一共2种状态可选，ENABLED：启用，DISABLED：停用
        /// </summary>
        [JsonProperty("TaskState")]
        public string TaskState{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 判断任务成功的操作符
        /// </summary>
        [JsonProperty("SuccessOperator")]
        public string SuccessOperator{ get; set; }

        /// <summary>
        /// 判断任务成功的阈值
        /// </summary>
        [JsonProperty("SuccessRatio")]
        public long? SuccessRatio{ get; set; }

        /// <summary>
        /// 分片数量
        /// </summary>
        [JsonProperty("ShardCount")]
        public long? ShardCount{ get; set; }

        /// <summary>
        /// 高级设置
        /// </summary>
        [JsonProperty("AdvanceSettings")]
        public AdvanceSettings AdvanceSettings{ get; set; }

        /// <summary>
        /// 分片参数
        /// </summary>
        [JsonProperty("ShardArguments")]
        public ShardArgument[] ShardArguments{ get; set; }

        /// <summary>
        /// 所属工作流ID
        /// </summary>
        [JsonProperty("BelongFlowIds")]
        public string[] BelongFlowIds{ get; set; }

        /// <summary>
        /// 任务历史ID
        /// </summary>
        [JsonProperty("TaskLogId")]
        public string TaskLogId{ get; set; }

        /// <summary>
        /// 触发类型，一共3种类型，WorkFlow：工作流触发，Cron：定时触发，FixRate：周期触发
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// 任务参数，长度限制10000个字符
        /// </summary>
        [JsonProperty("TaskArgument")]
        public string TaskArgument{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "ExecuteType", this.ExecuteType);
            this.SetParamSimple(map, prefix + "TaskContent", this.TaskContent);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "TimeOut", this.TimeOut);
            this.SetParamSimple(map, prefix + "RetryCount", this.RetryCount);
            this.SetParamSimple(map, prefix + "RetryInterval", this.RetryInterval);
            this.SetParamObj(map, prefix + "TaskRule.", this.TaskRule);
            this.SetParamSimple(map, prefix + "TaskState", this.TaskState);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "SuccessOperator", this.SuccessOperator);
            this.SetParamSimple(map, prefix + "SuccessRatio", this.SuccessRatio);
            this.SetParamSimple(map, prefix + "ShardCount", this.ShardCount);
            this.SetParamObj(map, prefix + "AdvanceSettings.", this.AdvanceSettings);
            this.SetParamArrayObj(map, prefix + "ShardArguments.", this.ShardArguments);
            this.SetParamArraySimple(map, prefix + "BelongFlowIds.", this.BelongFlowIds);
            this.SetParamSimple(map, prefix + "TaskLogId", this.TaskLogId);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "TaskArgument", this.TaskArgument);
        }
    }
}

