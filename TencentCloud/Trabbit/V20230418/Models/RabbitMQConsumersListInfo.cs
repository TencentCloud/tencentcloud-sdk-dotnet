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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQConsumersListInfo : AbstractModel
    {
        
        /// <summary>
        /// 客户端Ip
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// 消费者Tag
        /// </summary>
        [JsonProperty("ConsumerTag")]
        public string ConsumerTag{ get; set; }

        /// <summary>
        /// 消费目标队列
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// 是否需要消费者手动 ack
        /// </summary>
        [JsonProperty("AckRequired")]
        public bool? AckRequired{ get; set; }

        /// <summary>
        /// 消费者 qos 值
        /// </summary>
        [JsonProperty("PrefetchCount")]
        public ulong? PrefetchCount{ get; set; }

        /// <summary>
        /// 消费者状态
        /// </summary>
        [JsonProperty("Active")]
        public string Active{ get; set; }

        /// <summary>
        /// 最后一次投递消息时间
        /// </summary>
        [JsonProperty("LastDeliveredTime")]
        public string LastDeliveredTime{ get; set; }

        /// <summary>
        /// 消费者未确认消息数
        /// </summary>
        [JsonProperty("UnAckMsgCount")]
        public long? UnAckMsgCount{ get; set; }

        /// <summary>
        /// consumer 所属的 channel 
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "ConsumerTag", this.ConsumerTag);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "AckRequired", this.AckRequired);
            this.SetParamSimple(map, prefix + "PrefetchCount", this.PrefetchCount);
            this.SetParamSimple(map, prefix + "Active", this.Active);
            this.SetParamSimple(map, prefix + "LastDeliveredTime", this.LastDeliveredTime);
            this.SetParamSimple(map, prefix + "UnAckMsgCount", this.UnAckMsgCount);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
        }
    }
}

