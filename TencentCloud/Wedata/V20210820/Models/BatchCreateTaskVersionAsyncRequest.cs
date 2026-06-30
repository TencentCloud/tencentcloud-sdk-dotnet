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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchCreateTaskVersionAsyncRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>任务信息</p>
        /// </summary>
        [JsonProperty("Tasks")]
        public BatchCreateTaskVersionDTO[] Tasks{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>是否自动运行</p>
        /// </summary>
        [JsonProperty("AutoRun")]
        public bool? AutoRun{ get; set; }

        /// <summary>
        /// <p>告警方式:email-邮件;sms-短信;wecom-企业微信</p>
        /// </summary>
        [JsonProperty("AlarmWays")]
        public string AlarmWays{ get; set; }

        /// <summary>
        /// <p>告警对象:1-项目管理员，2-任务责任人</p>
        /// </summary>
        [JsonProperty("AlarmRecipientTypes")]
        public string AlarmRecipientTypes{ get; set; }

        /// <summary>
        /// <p>是否需要校验父任务已经提交到调度</p>
        /// </summary>
        [JsonProperty("NeedCheckParentSubmitted")]
        public bool? NeedCheckParentSubmitted{ get; set; }

        /// <summary>
        /// <p>是否需要补录中间实例</p>
        /// </summary>
        [JsonProperty("EnableMakeUp")]
        public bool? EnableMakeUp{ get; set; }

        /// <summary>
        /// <p>指定审批人列表</p>
        /// </summary>
        [JsonProperty("AssignApprovalList")]
        public string[] AssignApprovalList{ get; set; }

        /// <summary>
        /// <p>任务缺失实例处理策略</p><p>MAKEUP:补录缺失的实例;FORCE_SUCCESS:将缺失的实例置成功;SKIP:不处理，忽略缺失的实例</p>
        /// </summary>
        [JsonProperty("PerTaskMissingInstanceStrategy")]
        public TaskMissingInstanceStrategy[] PerTaskMissingInstanceStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AutoRun", this.AutoRun);
            this.SetParamSimple(map, prefix + "AlarmWays", this.AlarmWays);
            this.SetParamSimple(map, prefix + "AlarmRecipientTypes", this.AlarmRecipientTypes);
            this.SetParamSimple(map, prefix + "NeedCheckParentSubmitted", this.NeedCheckParentSubmitted);
            this.SetParamSimple(map, prefix + "EnableMakeUp", this.EnableMakeUp);
            this.SetParamArraySimple(map, prefix + "AssignApprovalList.", this.AssignApprovalList);
            this.SetParamArrayObj(map, prefix + "PerTaskMissingInstanceStrategy.", this.PerTaskMissingInstanceStrategy);
        }
    }
}

