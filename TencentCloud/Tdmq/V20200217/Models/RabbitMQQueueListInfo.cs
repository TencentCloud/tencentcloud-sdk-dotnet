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

    public class RabbitMQQueueListInfo : AbstractModel
    {
        
        /// <summary>
        /// 队列名
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// 备注说明
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 消费者信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsumerDetail")]
        public RabbitMQQueueListConsumerDetailInfo ConsumerDetail{ get; set; }

        /// <summary>
        /// 队列类型，取值 "classic"，"quorum"
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueType")]
        public string QueueType{ get; set; }

        /// <summary>
        /// 消息堆积数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MessageHeapCount")]
        public long? MessageHeapCount{ get; set; }

        /// <summary>
        /// 消息生产速率，每秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MessageRateIn")]
        public float? MessageRateIn{ get; set; }

        /// <summary>
        /// 消息消费速率，每秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MessageRateOut")]
        public float? MessageRateOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamObj(map, prefix + "ConsumerDetail.", this.ConsumerDetail);
            this.SetParamSimple(map, prefix + "QueueType", this.QueueType);
            this.SetParamSimple(map, prefix + "MessageHeapCount", this.MessageHeapCount);
            this.SetParamSimple(map, prefix + "MessageRateIn", this.MessageRateIn);
            this.SetParamSimple(map, prefix + "MessageRateOut", this.MessageRateOut);
        }
    }
}

