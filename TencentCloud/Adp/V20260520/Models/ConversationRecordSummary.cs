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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConversationRecordSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>回复记录 ID，对应 messages 中回复消息的 record_id</p>
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// <p>用户提问记录 ID，对应 messages 中用户消息的 record_id</p>
        /// </summary>
        [JsonProperty("RelatedRecordId")]
        public string RelatedRecordId{ get; set; }

        /// <summary>
        /// <p>单次对话耗时信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeUsage")]
        public ConversationRecordTimeUsage TimeUsage{ get; set; }

        /// <summary>
        /// <p>单次对话 token 消耗信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TokenUsage")]
        public ConversationRecordTokenUsage TokenUsage{ get; set; }

        /// <summary>
        /// <p>单次对话失败信息；成功时为空</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public ConversationRecordErrorInfo ErrorInfo{ get; set; }

        /// <summary>
        /// <p>单次员工助理对话当前状态</p><p>枚举值：</p><ul><li>pending： 待处理</li><li>processing： 处理中</li><li>success： 成功</li><li>failed： 失败</li><li>stop： 停止</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "RelatedRecordId", this.RelatedRecordId);
            this.SetParamObj(map, prefix + "TimeUsage.", this.TimeUsage);
            this.SetParamObj(map, prefix + "TokenUsage.", this.TokenUsage);
            this.SetParamObj(map, prefix + "ErrorInfo.", this.ErrorInfo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

