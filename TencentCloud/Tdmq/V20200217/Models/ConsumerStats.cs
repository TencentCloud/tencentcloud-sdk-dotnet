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

    public class ConsumerStats : AbstractModel
    {
        
        /// <summary>
        /// 主题名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 所属Broker
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrokerName")]
        public string BrokerName{ get; set; }

        /// <summary>
        /// 队列编号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueId")]
        public long? QueueId{ get; set; }

        /// <summary>
        /// 消费者ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsumerClientId")]
        public string ConsumerClientId{ get; set; }

        /// <summary>
        /// 消费位点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsumerOffset")]
        public long? ConsumerOffset{ get; set; }

        /// <summary>
        /// 服务端位点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrokerOffset")]
        public long? BrokerOffset{ get; set; }

        /// <summary>
        /// 消息堆积条数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiffTotal")]
        public long? DiffTotal{ get; set; }

        /// <summary>
        /// 最近消费时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastTimestamp")]
        public long? LastTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "BrokerName", this.BrokerName);
            this.SetParamSimple(map, prefix + "QueueId", this.QueueId);
            this.SetParamSimple(map, prefix + "ConsumerClientId", this.ConsumerClientId);
            this.SetParamSimple(map, prefix + "ConsumerOffset", this.ConsumerOffset);
            this.SetParamSimple(map, prefix + "BrokerOffset", this.BrokerOffset);
            this.SetParamSimple(map, prefix + "DiffTotal", this.DiffTotal);
            this.SetParamSimple(map, prefix + "LastTimestamp", this.LastTimestamp);
        }
    }
}

