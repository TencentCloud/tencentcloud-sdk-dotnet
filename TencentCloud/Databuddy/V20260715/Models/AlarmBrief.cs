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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmBrief : AbstractModel
    {
        
        /// <summary>
        /// 告警 ID，创建时无需传入，由服务端生成
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmId")]
        public string AlarmId{ get; set; }

        /// <summary>
        /// 告警的监控对象类型，如工作流、任务等，当前支持 1. WORKFLOW 2. TASK
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmMonitorType")]
        public string AlarmMonitorType{ get; set; }

        /// <summary>
        /// 告警组，最多 50 个
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlarmGroups")]
        public AlarmGroup[] AlarmGroups{ get; set; }

        /// <summary>
        /// 被跳过时免打扰，默认值 false
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DoNotDisturbWhenSkipped")]
        public bool? DoNotDisturbWhenSkipped{ get; set; }

        /// <summary>
        /// 被手动终止时免打扰，默认值 false
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DoNotDisturbWhenManuallyTerminated")]
        public bool? DoNotDisturbWhenManuallyTerminated{ get; set; }

        /// <summary>
        /// 最后一次重试前免打扰，默认值 false
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DoNotDisturbUntilTheLastRetry")]
        public bool? DoNotDisturbUntilTheLastRetry{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlarmId", this.AlarmId);
            this.SetParamSimple(map, prefix + "AlarmMonitorType", this.AlarmMonitorType);
            this.SetParamArrayObj(map, prefix + "AlarmGroups.", this.AlarmGroups);
            this.SetParamSimple(map, prefix + "DoNotDisturbWhenSkipped", this.DoNotDisturbWhenSkipped);
            this.SetParamSimple(map, prefix + "DoNotDisturbWhenManuallyTerminated", this.DoNotDisturbWhenManuallyTerminated);
            this.SetParamSimple(map, prefix + "DoNotDisturbUntilTheLastRetry", this.DoNotDisturbUntilTheLastRetry);
        }
    }
}

