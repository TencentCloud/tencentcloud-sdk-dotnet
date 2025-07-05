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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRocketMQMsgRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 主题，查询死信时传groupId
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        [JsonProperty("MsgId")]
        public string MsgId{ get; set; }

        /// <summary>
        /// pulsar消息id
        /// </summary>
        [JsonProperty("PulsarMsgId")]
        public string PulsarMsgId{ get; set; }

        /// <summary>
        /// 查询死信时该值为true，只对Rocketmq有效
        /// </summary>
        [JsonProperty("QueryDlqMsg")]
        [System.Obsolete]
        public bool? QueryDlqMsg{ get; set; }

        /// <summary>
        /// 查询死信时该值为true，只对Rocketmq有效
        /// </summary>
        [JsonProperty("QueryDeadLetterMessage")]
        public bool? QueryDeadLetterMessage{ get; set; }

        /// <summary>
        /// 分页Offset
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页Limit
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 根据消费组名称过滤消费详情
        /// </summary>
        [JsonProperty("FilterTrackGroup")]
        public string FilterTrackGroup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "PulsarMsgId", this.PulsarMsgId);
            this.SetParamSimple(map, prefix + "QueryDlqMsg", this.QueryDlqMsg);
            this.SetParamSimple(map, prefix + "QueryDeadLetterMessage", this.QueryDeadLetterMessage);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "FilterTrackGroup", this.FilterTrackGroup);
        }
    }
}

