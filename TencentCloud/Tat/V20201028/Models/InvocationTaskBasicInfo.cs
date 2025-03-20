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

    public class InvocationTaskBasicInfo : AbstractModel
    {
        
        /// <summary>
        /// 执行任务ID。
        /// </summary>
        [JsonProperty("InvocationTaskId")]
        public string InvocationTaskId{ get; set; }

        /// <summary>
        /// 执行任务状态。取值范围：
        /// 
        /// - PENDING：等待下发
        /// - DELIVERING：下发中
        /// - DELIVER_DELAYED：延时下发
        /// - DELIVER_FAILED：下发失败
        /// - START_FAILED：命令启动失败
        /// - RUNNING：命令运行中
        /// - SUCCESS：命令成功
        /// - FAILED：命令执行失败，执行完退出码不为 0
        /// - TIMEOUT：命令超时
        /// - TASK_TIMEOUT：客户端无响应
        /// - CANCELLING：取消中
        /// - CANCELLED：已取消（命令启动前就被取消）
        /// - TERMINATED：已中止（命令执行期间被取消）
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvocationTaskId", this.InvocationTaskId);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

