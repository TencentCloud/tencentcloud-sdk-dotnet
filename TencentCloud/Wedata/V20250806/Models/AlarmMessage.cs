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

    public class AlarmMessage : AbstractModel
    {
        
        /// <summary>
        /// <p>告警消息Id</p>
        /// </summary>
        [JsonProperty("AlarmMessageId")]
        public ulong? AlarmMessageId{ get; set; }

        /// <summary>
        /// <p>告警时间，同一条告警可能发送多次，只显示最新的告警时间</p>
        /// </summary>
        [JsonProperty("AlarmTime")]
        public string AlarmTime{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>任务Id</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务的实例数据时间</p>
        /// </summary>
        [JsonProperty("CurRunDate")]
        public string CurRunDate{ get; set; }

        /// <summary>
        /// <p>告警原因</p>
        /// </summary>
        [JsonProperty("AlarmReason")]
        public string AlarmReason{ get; set; }

        /// <summary>
        /// <p>告警级别，1.普通， 2.重要，3.紧急</p>
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// <p>告警规则Id</p>
        /// </summary>
        [JsonProperty("AlarmRuleId")]
        public string AlarmRuleId{ get; set; }

        /// <summary>
        /// <p>告警渠道 1.邮件，2.短信，3.微信，4.语音，5.企业微信，6.Http，7.企业微信群， 8.飞书群，9.钉钉群，10.Slack群,11.Teams群（默认1.邮件），7.企业微信群，8.飞书群，9.钉钉群，10.Slack群，11.Teams群</p>
        /// </summary>
        [JsonProperty("AlarmWays")]
        public string[] AlarmWays{ get; set; }

        /// <summary>
        /// <p>告警接收人</p>
        /// </summary>
        [JsonProperty("AlarmRecipients")]
        public string[] AlarmRecipients{ get; set; }

        /// <summary>
        /// <p>自定义邮箱列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomEmails")]
        public string[] CustomEmails{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmMessageId", this.AlarmMessageId);
            this.SetParamSimple(map, prefix + "AlarmTime", this.AlarmTime);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "CurRunDate", this.CurRunDate);
            this.SetParamSimple(map, prefix + "AlarmReason", this.AlarmReason);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "AlarmRuleId", this.AlarmRuleId);
            this.SetParamArraySimple(map, prefix + "AlarmWays.", this.AlarmWays);
            this.SetParamArraySimple(map, prefix + "AlarmRecipients.", this.AlarmRecipients);
            this.SetParamArraySimple(map, prefix + "CustomEmails.", this.CustomEmails);
        }
    }
}

