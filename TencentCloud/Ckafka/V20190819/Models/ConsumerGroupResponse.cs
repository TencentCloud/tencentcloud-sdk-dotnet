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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConsumerGroupResponse : AbstractModel
    {
        
        /// <summary>
        /// 符合条件的消费组数量
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 主题列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicList")]
        public ConsumerGroupTopic[] TopicList{ get; set; }

        /// <summary>
        /// 消费分组List
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupList")]
        public ConsumerGroup[] GroupList{ get; set; }

        /// <summary>
        /// 所有分区数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalPartition")]
        public long? TotalPartition{ get; set; }

        /// <summary>
        /// 监控的分区列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PartitionListForMonitor")]
        public Partition[] PartitionListForMonitor{ get; set; }

        /// <summary>
        /// 主题总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalTopic")]
        public long? TotalTopic{ get; set; }

        /// <summary>
        /// 监控的主题列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicListForMonitor")]
        public ConsumerGroupTopic[] TopicListForMonitor{ get; set; }

        /// <summary>
        /// 监控的组列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupListForMonitor")]
        public Group[] GroupListForMonitor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "TopicList.", this.TopicList);
            this.SetParamArrayObj(map, prefix + "GroupList.", this.GroupList);
            this.SetParamSimple(map, prefix + "TotalPartition", this.TotalPartition);
            this.SetParamArrayObj(map, prefix + "PartitionListForMonitor.", this.PartitionListForMonitor);
            this.SetParamSimple(map, prefix + "TotalTopic", this.TotalTopic);
            this.SetParamArrayObj(map, prefix + "TopicListForMonitor.", this.TopicListForMonitor);
            this.SetParamArrayObj(map, prefix + "GroupListForMonitor.", this.GroupListForMonitor);
        }
    }
}

