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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JobResult : AbstractModel
    {
        
        /// <summary>
        /// 任务步骤名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 任务步骤失败时的处理策略，可以为以下值：
        /// "CONTINUE"，跳过当前失败步骤，继续后续步骤。
        /// “TERMINATE_CLUSTER”，终止当前及后续步骤，并销毁集群。
        /// “CANCEL_AND_WAIT”，取消当前步骤并阻塞等待处理。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionOnFailure")]
        public string ActionOnFailure{ get; set; }

        /// <summary>
        /// 当前步骤的状态，可以为以下值：
        /// “JobFlowStepStatusInit”，初始化状态，等待执行。
        /// “JobFlowStepStatusRunning”，任务步骤正在执行。
        /// “JobFlowStepStatusFailed”，任务步骤执行失败。
        /// “JobFlowStepStatusSucceed”，任务步骤执行成功。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobState")]
        public string JobState{ get; set; }

        /// <summary>
        /// YARN任务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ActionOnFailure", this.ActionOnFailure);
            this.SetParamSimple(map, prefix + "JobState", this.JobState);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
        }
    }
}

