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

    public class DescribeConversationMessageListResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>第一个记录 ID</p>
        /// </summary>
        [JsonProperty("FirstRecordId")]
        public string FirstRecordId{ get; set; }

        /// <summary>
        /// <p>更新消息方向是否还有更多</p>
        /// </summary>
        [JsonProperty("HasMoreAfter")]
        public bool? HasMoreAfter{ get; set; }

        /// <summary>
        /// <p>更早消息方向是否还有更多</p>
        /// </summary>
        [JsonProperty("HasMoreBefore")]
        public bool? HasMoreBefore{ get; set; }

        /// <summary>
        /// <p>最后一个记录 ID</p>
        /// </summary>
        [JsonProperty("LastRecordId")]
        public string LastRecordId{ get; set; }

        /// <summary>
        /// <p>消息列表</p>
        /// </summary>
        [JsonProperty("MessageList")]
        public ConversationMessage[] MessageList{ get; set; }

        /// <summary>
        /// <p>消息列表</p>
        /// </summary>
        [JsonProperty("Messages")]
        [System.Obsolete]
        public ConversationMessage[] Messages{ get; set; }

        /// <summary>
        /// <p>最近一次重置信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResetInfo")]
        public ConversationResetInfo ResetInfo{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FirstRecordId", this.FirstRecordId);
            this.SetParamSimple(map, prefix + "HasMoreAfter", this.HasMoreAfter);
            this.SetParamSimple(map, prefix + "HasMoreBefore", this.HasMoreBefore);
            this.SetParamSimple(map, prefix + "LastRecordId", this.LastRecordId);
            this.SetParamArrayObj(map, prefix + "MessageList.", this.MessageList);
            this.SetParamArrayObj(map, prefix + "Messages.", this.Messages);
            this.SetParamObj(map, prefix + "ResetInfo.", this.ResetInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

