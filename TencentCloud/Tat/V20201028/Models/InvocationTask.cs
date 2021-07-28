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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InvocationTask : AbstractModel
    {
        
        /// <summary>
        /// 执行活动ID。
        /// </summary>
        [JsonProperty("InvocationId")]
        public string InvocationId{ get; set; }

        /// <summary>
        /// 执行任务ID。
        /// </summary>
        [JsonProperty("InvocationTaskId")]
        public string InvocationTaskId{ get; set; }

        /// <summary>
        /// 命令ID。
        /// </summary>
        [JsonProperty("CommandId")]
        public string CommandId{ get; set; }

        /// <summary>
        /// 执行任务状态。取值范围：
        /// <li> PENDING：等待下发 
        /// <li> DELIVERING：下发中
        /// <li> DELIVER_DELAYED：延时下发 
        /// <li> DELIVER_FAILED：下发失败
        /// <li> RUNNING：命令运行中
        /// <li> SUCCESS：命令成功
        /// <li> FAILED：命令失败
        /// <li> TIMEOUT：命令超时
        /// <li> TASK_TIMEOUT：执行任务超时
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 执行结果。
        /// </summary>
        [JsonProperty("TaskResult")]
        public TaskResult TaskResult{ get; set; }

        /// <summary>
        /// 执行任务开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 执行任务结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// 执行任务所执行的命令详情。
        /// </summary>
        [JsonProperty("CommandDocument")]
        public CommandDocument CommandDocument{ get; set; }

        /// <summary>
        /// 执行任务失败时的错误信息。
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public string ErrorInfo{ get; set; }

        /// <summary>
        /// 调用来源。
        /// </summary>
        [JsonProperty("InvocationSource")]
        public string InvocationSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvocationId", this.InvocationId);
            this.SetParamSimple(map, prefix + "InvocationTaskId", this.InvocationTaskId);
            this.SetParamSimple(map, prefix + "CommandId", this.CommandId);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamObj(map, prefix + "TaskResult.", this.TaskResult);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamObj(map, prefix + "CommandDocument.", this.CommandDocument);
            this.SetParamSimple(map, prefix + "ErrorInfo", this.ErrorInfo);
            this.SetParamSimple(map, prefix + "InvocationSource", this.InvocationSource);
        }
    }
}

