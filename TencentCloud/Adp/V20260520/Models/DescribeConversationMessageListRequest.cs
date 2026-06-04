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

    public class DescribeConversationMessageListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>会话 ID</p>
        /// </summary>
        [JsonProperty("ConversationId")]
        public string ConversationId{ get; set; }

        /// <summary>
        /// <p>会话类型 枚举值: 0-CONVERSATION_TYPE_UNSPECIFIED(未指定；列表查询时表示全部), 1-CONVERSATION_TYPE_VISITOR(访客端体验), 2-CONVERSATION_TYPE_EVALUATION(评测), 5-CONVERSATION_TYPE_API(API 接入), 10-CONVERSATION_TYPE_WORKFLOW(工作流调试), 20-CONVERSATION_TYPE_SHARE(分享链接)</p>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>Type=CONVERSATION_TYPE_API 时必填，应用密钥</p>
        /// </summary>
        [JsonProperty("AppKey")]
        public string AppKey{ get; set; }

        /// <summary>
        /// <p>返回记录总数量，默认 10，最大 50。向前或向后查询时，不包含record_id指定记录的消息，查询方向中心向前后查询时，包含record_id指定的记录消息，返回记录数量为前后各limit / 2条，向上取整</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>子用户Uin</p>
        /// </summary>
        [JsonProperty("LoginSubAccountUin")]
        public string LoginSubAccountUin{ get; set; }

        /// <summary>
        /// <p>主用户Uin</p>
        /// </summary>
        [JsonProperty("LoginUin")]
        public string LoginUin{ get; set; }

        /// <summary>
        /// <p>查询锚点记录 ID</p>
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// <p>相对于 record_id 的查询方向 枚举值: 0-RECORD_QUERY_DIRECTION_UNSPECIFIED(未指定，兼容旧逻辑，默认向前查询), 1-RECORD_QUERY_DIRECTION_BACKWARD(从 record_id 向前查询更早的消息), 2-RECORD_QUERY_DIRECTION_FORWARD(从 record_id 向后查询更新的消息), 3-RECORD_QUERY_DIRECTION_BIDIRECTIONAL(以 record_id 为中心，同时向前后查询)</p>
        /// </summary>
        [JsonProperty("RecordQueryDirection")]
        public long? RecordQueryDirection{ get; set; }

        /// <summary>
        /// <p>Type=CONVERSATION_TYPE_SHARE 时必填，分享码</p>
        /// </summary>
        [JsonProperty("ShareCode")]
        public string ShareCode{ get; set; }

        /// <summary>
        /// <p>Type=CONVERSATION_TYPE_API 时必填，访客ID</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConversationId", this.ConversationId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AppKey", this.AppKey);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "LoginSubAccountUin", this.LoginSubAccountUin);
            this.SetParamSimple(map, prefix + "LoginUin", this.LoginUin);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "RecordQueryDirection", this.RecordQueryDirection);
            this.SetParamSimple(map, prefix + "ShareCode", this.ShareCode);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

