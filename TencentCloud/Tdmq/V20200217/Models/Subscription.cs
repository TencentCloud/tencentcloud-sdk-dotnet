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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Subscription : AbstractModel
    {
        
        /// <summary>
        /// 主题名称。
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 环境（命名空间）名称。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 消费者开始连接的时间。
        /// </summary>
        [JsonProperty("ConnectedSince")]
        public string ConnectedSince{ get; set; }

        /// <summary>
        /// 消费者地址。
        /// </summary>
        [JsonProperty("ConsumerAddr")]
        public string ConsumerAddr{ get; set; }

        /// <summary>
        /// 消费者数量。
        /// </summary>
        [JsonProperty("ConsumerCount")]
        public string ConsumerCount{ get; set; }

        /// <summary>
        /// 消费者名称。
        /// </summary>
        [JsonProperty("ConsumerName")]
        public string ConsumerName{ get; set; }

        /// <summary>
        /// 堆积的消息数量。
        /// </summary>
        [JsonProperty("MsgBacklog")]
        public string MsgBacklog{ get; set; }

        /// <summary>
        /// 于TTL，此订阅下没有被发送而是被丢弃的比例。
        /// </summary>
        [JsonProperty("MsgRateExpired")]
        public string MsgRateExpired{ get; set; }

        /// <summary>
        /// 消费者每秒分发消息的数量之和。
        /// </summary>
        [JsonProperty("MsgRateOut")]
        public string MsgRateOut{ get; set; }

        /// <summary>
        /// 消费者每秒消息的byte。
        /// </summary>
        [JsonProperty("MsgThroughputOut")]
        public string MsgThroughputOut{ get; set; }

        /// <summary>
        /// 订阅名称。
        /// </summary>
        [JsonProperty("SubscriptionName")]
        public string SubscriptionName{ get; set; }

        /// <summary>
        /// 消费者集合。
        /// </summary>
        [JsonProperty("ConsumerSets")]
        public Consumer[] ConsumerSets{ get; set; }

        /// <summary>
        /// 是否在线。
        /// </summary>
        [JsonProperty("IsOnline")]
        public bool? IsOnline{ get; set; }

        /// <summary>
        /// 消费进度集合。
        /// </summary>
        [JsonProperty("ConsumersScheduleSets")]
        public ConsumersSchedule[] ConsumersScheduleSets{ get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最近修改时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 订阅类型，Exclusive，Shared，Failover， Key_Shared，空或NULL表示未知，
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// 是否由于未 ack 数到达上限而被 block
        /// </summary>
        [JsonProperty("BlockedSubscriptionOnUnackedMsgs")]
        public bool? BlockedSubscriptionOnUnackedMsgs{ get; set; }

        /// <summary>
        /// 未 ack 消息数上限
        /// </summary>
        [JsonProperty("MaxUnackedMsgNum")]
        public long? MaxUnackedMsgNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "ConnectedSince", this.ConnectedSince);
            this.SetParamSimple(map, prefix + "ConsumerAddr", this.ConsumerAddr);
            this.SetParamSimple(map, prefix + "ConsumerCount", this.ConsumerCount);
            this.SetParamSimple(map, prefix + "ConsumerName", this.ConsumerName);
            this.SetParamSimple(map, prefix + "MsgBacklog", this.MsgBacklog);
            this.SetParamSimple(map, prefix + "MsgRateExpired", this.MsgRateExpired);
            this.SetParamSimple(map, prefix + "MsgRateOut", this.MsgRateOut);
            this.SetParamSimple(map, prefix + "MsgThroughputOut", this.MsgThroughputOut);
            this.SetParamSimple(map, prefix + "SubscriptionName", this.SubscriptionName);
            this.SetParamArrayObj(map, prefix + "ConsumerSets.", this.ConsumerSets);
            this.SetParamSimple(map, prefix + "IsOnline", this.IsOnline);
            this.SetParamArrayObj(map, prefix + "ConsumersScheduleSets.", this.ConsumersScheduleSets);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamSimple(map, prefix + "BlockedSubscriptionOnUnackedMsgs", this.BlockedSubscriptionOnUnackedMsgs);
            this.SetParamSimple(map, prefix + "MaxUnackedMsgNum", this.MaxUnackedMsgNum);
        }
    }
}

