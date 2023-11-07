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

    public class RocketMQClusterConfig : AbstractModel
    {
        
        /// <summary>
        /// 单命名空间TPS上线
        /// </summary>
        [JsonProperty("MaxTpsPerNamespace")]
        public ulong? MaxTpsPerNamespace{ get; set; }

        /// <summary>
        /// 最大命名空间数量
        /// </summary>
        [JsonProperty("MaxNamespaceNum")]
        public ulong? MaxNamespaceNum{ get; set; }

        /// <summary>
        /// 已使用命名空间数量
        /// </summary>
        [JsonProperty("UsedNamespaceNum")]
        public ulong? UsedNamespaceNum{ get; set; }

        /// <summary>
        /// 最大Topic数量
        /// </summary>
        [JsonProperty("MaxTopicNum")]
        public ulong? MaxTopicNum{ get; set; }

        /// <summary>
        /// 已使用Topic数量
        /// </summary>
        [JsonProperty("UsedTopicNum")]
        public ulong? UsedTopicNum{ get; set; }

        /// <summary>
        /// 最大Group数量
        /// </summary>
        [JsonProperty("MaxGroupNum")]
        public ulong? MaxGroupNum{ get; set; }

        /// <summary>
        /// 已使用Group数量
        /// </summary>
        [JsonProperty("UsedGroupNum")]
        public ulong? UsedGroupNum{ get; set; }

        /// <summary>
        /// 消息最大保留时间，以毫秒为单位
        /// </summary>
        [JsonProperty("MaxRetentionTime")]
        public ulong? MaxRetentionTime{ get; set; }

        /// <summary>
        /// 消息最长延时，以毫秒为单位
        /// </summary>
        [JsonProperty("MaxLatencyTime")]
        public ulong? MaxLatencyTime{ get; set; }

        /// <summary>
        /// 单个主题最大队列数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxQueuesPerTopic")]
        public ulong? MaxQueuesPerTopic{ get; set; }

        /// <summary>
        /// topic分布
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TopicDistribution")]
        public RocketMQTopicDistribution[] TopicDistribution{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxTpsPerNamespace", this.MaxTpsPerNamespace);
            this.SetParamSimple(map, prefix + "MaxNamespaceNum", this.MaxNamespaceNum);
            this.SetParamSimple(map, prefix + "UsedNamespaceNum", this.UsedNamespaceNum);
            this.SetParamSimple(map, prefix + "MaxTopicNum", this.MaxTopicNum);
            this.SetParamSimple(map, prefix + "UsedTopicNum", this.UsedTopicNum);
            this.SetParamSimple(map, prefix + "MaxGroupNum", this.MaxGroupNum);
            this.SetParamSimple(map, prefix + "UsedGroupNum", this.UsedGroupNum);
            this.SetParamSimple(map, prefix + "MaxRetentionTime", this.MaxRetentionTime);
            this.SetParamSimple(map, prefix + "MaxLatencyTime", this.MaxLatencyTime);
            this.SetParamSimple(map, prefix + "MaxQueuesPerTopic", this.MaxQueuesPerTopic);
            this.SetParamArrayObj(map, prefix + "TopicDistribution.", this.TopicDistribution);
        }
    }
}

