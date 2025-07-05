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

    public class DescribeAlarmReceiverRequest : AbstractModel
    {
        
        /// <summary>
        /// 告警ID
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("TaskType")]
        public ulong? TaskType{ get; set; }

        /// <summary>
        /// 告警接收人ID(逗号分隔)
        /// </summary>
        [JsonProperty("AlarmRecipient")]
        public string AlarmRecipient{ get; set; }

        /// <summary>
        /// 告警接收人姓名(逗号分隔)
        /// </summary>
        [JsonProperty("AlarmRecipientName")]
        public string AlarmRecipientName{ get; set; }

        /// <summary>
        /// 告警时间
        /// </summary>
        [JsonProperty("AlarmTime")]
        public string AlarmTime{ get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonProperty("MessageId")]
        public string MessageId{ get; set; }

        /// <summary>
        /// 告警记录id
        /// </summary>
        [JsonProperty("RecordId")]
        public ulong? RecordId{ get; set; }

        /// <summary>
        /// 监控对象类型(1:所有任务,2:指定任务,3:指定责任人,4:指定资源组)
        /// </summary>
        [JsonProperty("MonitorType")]
        public ulong? MonitorType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "AlarmRecipient", this.AlarmRecipient);
            this.SetParamSimple(map, prefix + "AlarmRecipientName", this.AlarmRecipientName);
            this.SetParamSimple(map, prefix + "AlarmTime", this.AlarmTime);
            this.SetParamSimple(map, prefix + "MessageId", this.MessageId);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
        }
    }
}

