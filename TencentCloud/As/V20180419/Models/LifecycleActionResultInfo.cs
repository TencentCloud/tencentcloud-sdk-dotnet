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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LifecycleActionResultInfo : AbstractModel
    {
        
        /// <summary>
        /// 生命周期挂钩标识。
        /// </summary>
        [JsonProperty("LifecycleHookId")]
        public string LifecycleHookId{ get; set; }

        /// <summary>
        /// 实例标识。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 执行活动ID。可通过TAT的[查询执行活动](https://cloud.tencent.com/document/api/1340/52679)API查询具体的执行结果。
        /// </summary>
        [JsonProperty("InvocationId")]
        public string InvocationId{ get; set; }

        /// <summary>
        /// 命令调用的结果，表示执行TAT命令是否成功。<br>
        /// <li>SUCCESSFUL 命令调用成功，不代表命令执行成功，执行的具体情况可根据InvocationId进行查询</li>
        /// <li>FAILED 命令调用失败</li>
        /// <li>NONE</li>
        /// </summary>
        [JsonProperty("InvokeCommandResult")]
        public string InvokeCommandResult{ get; set; }

        /// <summary>
        /// 通知的结果，表示通知CMQ/TDMQ是否成功。<br>
        /// <li>SUCCESSFUL 通知成功</li>
        /// <li>FAILED 通知失败</li>
        /// <li>NONE</li>
        /// </summary>
        [JsonProperty("NotificationResult")]
        public string NotificationResult{ get; set; }

        /// <summary>
        /// 生命周期挂钩动作的执行结果，取值包括 CONTINUE、ABANDON。
        /// </summary>
        [JsonProperty("LifecycleActionResult")]
        public string LifecycleActionResult{ get; set; }

        /// <summary>
        /// 结果的原因。<br>
        /// <li>HEARTBEAT_TIMEOUT 由于心跳超时，结果根据DefaultResult设置。</li>
        /// <li>NOTIFICATION_FAILURE 由于发送通知失败，结果根据DefaultResult设置。</li>
        /// <li>CALL_INTERFACE 调用了接口CompleteLifecycleAction设置结果。</li>
        /// <li>ANOTHER_ACTION_ABANDON 另一个生命周期操作的结果已设置为“ABANDON”。</li>
        /// <li>COMMAND_CALL_FAILURE  由于命令调用失败，结果根据DefaultResult设置。</li>
        /// <li>COMMAND_EXEC_FINISH  命令执行完成。</li>
        /// <li>COMMAND_EXEC_FAILURE 由于命令执行失败，结果根据DefaultResult设置。</li>
        /// <li>COMMAND_EXEC_RESULT_CHECK_FAILURE 由于命令结果检查失败，结果根据DefaultResult设置。</li>
        /// </summary>
        [JsonProperty("ResultReason")]
        public string ResultReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LifecycleHookId", this.LifecycleHookId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InvocationId", this.InvocationId);
            this.SetParamSimple(map, prefix + "InvokeCommandResult", this.InvokeCommandResult);
            this.SetParamSimple(map, prefix + "NotificationResult", this.NotificationResult);
            this.SetParamSimple(map, prefix + "LifecycleActionResult", this.LifecycleActionResult);
            this.SetParamSimple(map, prefix + "ResultReason", this.ResultReason);
        }
    }
}

