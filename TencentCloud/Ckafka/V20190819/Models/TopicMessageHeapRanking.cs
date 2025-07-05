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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopicMessageHeapRanking : AbstractModel
    {
        
        /// <summary>
        /// 主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 主题名称
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 分区数
        /// </summary>
        [JsonProperty("PartitionNum")]
        public ulong? PartitionNum{ get; set; }

        /// <summary>
        /// 副本数
        /// </summary>
        [JsonProperty("ReplicaNum")]
        public ulong? ReplicaNum{ get; set; }

        /// <summary>
        /// Topic 流量
        /// </summary>
        [JsonProperty("TopicTraffic")]
        public string TopicTraffic{ get; set; }

        /// <summary>
        /// topic消息堆积/占用磁盘
        /// </summary>
        [JsonProperty("MessageHeap")]
        public ulong? MessageHeap{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "PartitionNum", this.PartitionNum);
            this.SetParamSimple(map, prefix + "ReplicaNum", this.ReplicaNum);
            this.SetParamSimple(map, prefix + "TopicTraffic", this.TopicTraffic);
            this.SetParamSimple(map, prefix + "MessageHeap", this.MessageHeap);
        }
    }
}

