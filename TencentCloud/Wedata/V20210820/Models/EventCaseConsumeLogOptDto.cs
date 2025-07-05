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

    public class EventCaseConsumeLogOptDto : AbstractModel
    {
        
        /// <summary>
        /// 消费ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsumeLogId")]
        public string ConsumeLogId{ get; set; }

        /// <summary>
        /// 事件案例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventCaseId")]
        public string EventCaseId{ get; set; }

        /// <summary>
        /// 消费者ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsumerId")]
        public string ConsumerId{ get; set; }

        /// <summary>
        /// 消费时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreationTimestamp")]
        public string CreationTimestamp{ get; set; }

        /// <summary>
        /// 任务详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsumerDetail")]
        public TaskOpsDto ConsumerDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsumeLogId", this.ConsumeLogId);
            this.SetParamSimple(map, prefix + "EventCaseId", this.EventCaseId);
            this.SetParamSimple(map, prefix + "ConsumerId", this.ConsumerId);
            this.SetParamSimple(map, prefix + "CreationTimestamp", this.CreationTimestamp);
            this.SetParamObj(map, prefix + "ConsumerDetail.", this.ConsumerDetail);
        }
    }
}

