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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopicStatsDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Broker节点名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrokerName")]
        public string BrokerName{ get; set; }

        /// <summary>
        /// <p>队列编号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueueId")]
        public long? QueueId{ get; set; }

        /// <summary>
        /// <p>生产消息位点</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BrokerOffset")]
        public long? BrokerOffset{ get; set; }

        /// <summary>
        /// <p>最新消费位点</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CommitOffset")]
        public long? CommitOffset{ get; set; }

        /// <summary>
        /// <p>堆积总数</p><p>单位：条</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MessageCount")]
        public long? MessageCount{ get; set; }

        /// <summary>
        /// <p>最后消费时间</p><p>单位：毫秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastUpdateTimestamp")]
        public long? LastUpdateTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BrokerName", this.BrokerName);
            this.SetParamSimple(map, prefix + "QueueId", this.QueueId);
            this.SetParamSimple(map, prefix + "BrokerOffset", this.BrokerOffset);
            this.SetParamSimple(map, prefix + "CommitOffset", this.CommitOffset);
            this.SetParamSimple(map, prefix + "MessageCount", this.MessageCount);
            this.SetParamSimple(map, prefix + "LastUpdateTimestamp", this.LastUpdateTimestamp);
        }
    }
}

