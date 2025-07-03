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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMessageListRequest : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云 RocketMQ 实例 ID，从 [DescribeFusionInstanceList](https://cloud.tencent.com/document/api/1493/106745) 接口或控制台获得。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 主题名称，从 [DescribeTopicList](https://cloud.tencent.com/document/api/1493/96030) 接口返回的 [TopicItem](https://cloud.tencent.com/document/api/1493/96031#TopicItem) 或控制台获得。
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// 要查询消息的开始时间，**Unix时间戳（毫秒）**
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 要查询消息的结束时间，**Unix时间戳（毫秒）**
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 一次查询标识。第一次查询可传空字符串，当查询结果涉及分页，请求下一页数据时该入参的值取上一次请求响应中的出参TaskRequestId 值即可。
        /// </summary>
        [JsonProperty("TaskRequestId")]
        public string TaskRequestId{ get; set; }

        /// <summary>
        /// 查询起始位置，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 查询结果限制数量，默认20。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 消费组名称，从 [DescribeConsumerGroupList](https://cloud.tencent.com/document/api/1493/101535) 接口返回的 [ConsumeGroupItem](https://cloud.tencent.com/document/api/1493/96031#ConsumeGroupItem) 或控制台获得。
        /// </summary>
        [JsonProperty("ConsumerGroup")]
        public string ConsumerGroup{ get; set; }

        /// <summary>
        /// 消息 ID，从 [DescribeMessageList](https://cloud.tencent.com/document/api/1493/114593) 接口返回的 [MessageItem](https://cloud.tencent.com/document/api/1493/96031#MessageItem) 或业务日志中获得。
        /// </summary>
        [JsonProperty("MsgId")]
        public string MsgId{ get; set; }

        /// <summary>
        /// 消息 Key，从 [DescribeMessageList](https://cloud.tencent.com/document/api/1493/114593) 接口返回的 [MessageItem](https://cloud.tencent.com/document/api/1493/96031#MessageItem) 或业务日志中获得。
        /// </summary>
        [JsonProperty("MsgKey")]
        public string MsgKey{ get; set; }

        /// <summary>
        /// 查询最近N条消息 最大不超过1024，默认-1为其他查询条件
        /// </summary>
        [JsonProperty("RecentMessageNum")]
        public long? RecentMessageNum{ get; set; }

        /// <summary>
        /// 是否查询死信消息，默认为false
        /// </summary>
        [JsonProperty("QueryDeadLetterMessage")]
        public bool? QueryDeadLetterMessage{ get; set; }

        /// <summary>
        /// 消息 Tag，从 [DescribeMessageList](https://cloud.tencent.com/document/api/1493/114593) 接口返回的 [MessageItem](https://cloud.tencent.com/document/api/1493/96031#MessageItem) 或业务日志中获得。
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TaskRequestId", this.TaskRequestId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ConsumerGroup", this.ConsumerGroup);
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "MsgKey", this.MsgKey);
            this.SetParamSimple(map, prefix + "RecentMessageNum", this.RecentMessageNum);
            this.SetParamSimple(map, prefix + "QueryDeadLetterMessage", this.QueryDeadLetterMessage);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
        }
    }
}

