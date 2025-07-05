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

    public class TopicStats : AbstractModel
    {
        
        /// <summary>
        /// 所属Broker节点
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
        /// 最小位点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinOffset")]
        public long? MinOffset{ get; set; }

        /// <summary>
        /// 最大位点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxOffset")]
        public long? MaxOffset{ get; set; }

        /// <summary>
        /// 消息条数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MessageCount")]
        public long? MessageCount{ get; set; }

        /// <summary>
        /// 消息最后写入时间
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
            this.SetParamSimple(map, prefix + "MinOffset", this.MinOffset);
            this.SetParamSimple(map, prefix + "MaxOffset", this.MaxOffset);
            this.SetParamSimple(map, prefix + "MessageCount", this.MessageCount);
            this.SetParamSimple(map, prefix + "LastUpdateTimestamp", this.LastUpdateTimestamp);
        }
    }
}

